namespace SimpleCrawler;

using System.Collections;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

public class SimpleCrawler {
	private int _count;
	private readonly Queue<string> _urls = new();

	private string _domain = string.Empty;
	private bool _isSpecificDomain;

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

	public void Crawl() {
		Console.WriteLine("开始爬行了.... ");
		while (this._urls.Count > 0 && this._count < 10) {
			string current = this._urls.Dequeue();
			
			Console.WriteLine("爬行 " + current + " 页面!");
			string html = this.DownLoad(current);
			++this._count;
			
			Uri uri = new Uri(current);
			// Only when is .html, .aspx, .jsp, then crawl
			if (true || uri.AbsolutePath.EndsWith(".html") || uri.AbsolutePath.EndsWith(".aspx") || uri.AbsolutePath.EndsWith(".jsp")) {
				this.Parse(html, uri);
			}
			
			Console.WriteLine("爬行结束");
		}
	}

	public string DownLoad(string url) {
		try {
			var webClient = new WebClient();
			webClient.Encoding = Encoding.UTF8;
			string html = webClient.DownloadString(url);
			var fileName = this._count.ToString();
			File.WriteAllText(fileName, html, Encoding.UTF8);
			return html;
		} catch (Exception ex) {
			Console.WriteLine(ex.Message);
			return "";
		}
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