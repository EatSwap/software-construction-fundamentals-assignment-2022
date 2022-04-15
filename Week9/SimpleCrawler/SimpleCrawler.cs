namespace SimpleCrawler;

using System.Text;
using System.Text.RegularExpressions;

public struct CrawlEventArgs {
	public string Url;
	public string Message;
	
	public CrawlEventArgs(string url, string message = "") {
		Url = url;
		Message = message;
	}
}

public delegate void CrawlEventHandler(object sender, CrawlEventArgs pageInfo);

public class SimpleCrawler {
	private int _count;
	private readonly Queue<string> _urls = new();

	private string _domain = string.Empty;
	private bool _isSpecificDomain;
	
	public event CrawlEventHandler OnSuccess;
	
	public event CrawlEventHandler OnError;
	
	public event CrawlEventHandler OnStart;

	public SimpleCrawler(params string[] u) {
		this._count = 0;
		foreach (var url in u) {
			this._urls.Enqueue(url);
		}
	}
	
	public void SetDomain(string domain) {
		this._domain = domain;
		this._isSpecificDomain = true;
	}
	
	public void ClearDomain() => this._isSpecificDomain = false;

	public void Crawl() {
		while (this._urls.Count > 0 && this._count < 10) {
			string current = this._urls.Dequeue();

			this.OnStart(this, new CrawlEventArgs(current));

			string html;
			try {
				html = this.Download(current);
				this.OnSuccess(this, new CrawlEventArgs(current));
			} catch (Exception ex) {
				this.OnError(this, new CrawlEventArgs(current, ex.Message));
				continue;
			}
			
			++this._count;
			
			var uri = new Uri(current);
			// Only when is .html, .aspx, .jsp, then crawl
			if (true || uri.AbsolutePath.EndsWith(".html") || uri.AbsolutePath.EndsWith(".aspx") || uri.AbsolutePath.EndsWith(".jsp"))
				this.Parse(html, uri);
		}
	}

	private string Download(string url) {
		var webClient = new WebClientRedirect();
		webClient.Encoding = Encoding.UTF8;
		
		string html = webClient.DownloadString(url);
		
		File.WriteAllText(this._count.ToString(), html, Encoding.UTF8);
		return html;
	}

	private void Parse(string html, Uri baseUrl) {
		var strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
		MatchCollection matches = new Regex(strRef).Matches(html);
		foreach (Match match in matches) {
			strRef = match.Value[(match.Value.IndexOf('=') + 1)..].Trim('"', '\"', '#', '>');
			if (!string.IsNullOrWhiteSpace(strRef)) {
				Uri uri = (strRef.StartsWith("http://") || strRef.StartsWith("https://")) ? new Uri(strRef) : new Uri(baseUrl, strRef);
				if ((!this._isSpecificDomain || uri.Host.EndsWith(this._domain)) && !this._urls.Contains(uri.AbsoluteUri))
					this._urls.Enqueue(uri.AbsoluteUri);
			}
		}
	}
}