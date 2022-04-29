namespace SimpleCrawler;

using System.Collections.Concurrent;
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

internal struct UrlInfo {
	public string Url;
	public int Depth;

	public UrlInfo(string url, int depth = 0) {
		this.Url = url;
		this.Depth = depth;
	}
}

public delegate void CrawlEventHandler(object sender, CrawlEventArgs pageInfo);

public class Crawler {
	private int _count = 0;
	private readonly object _countMutex = new();
	
	private int _finishedCount = 0;
	private readonly object _finishedCountMutex = new();
	
	private int _depth = 10;
	private readonly ConcurrentQueue<UrlInfo> _urls = new();
	private readonly ConcurrentBag<string> _vis = new();

	private string _domain = string.Empty;
	private bool _isSpecificDomain;
	private readonly Thread[] _threadPool;
	private readonly Semaphore _queueSemaphore = new(0, int.MaxValue);
	
	// Conditional Variable ???
	private readonly object _finishCV = new();

	public event CrawlEventHandler OnSuccess = (s, e) => { };
	
	public event CrawlEventHandler OnError = (s, e) => { };
	
	public event CrawlEventHandler OnStart = (s, e) => { };

	public Crawler(params string[] u) {
		foreach (var url in u) {
			this._urls.Enqueue(new(url));
		}

		this._threadPool = new Thread[Environment.ProcessorCount];
		for (int i = 0; i < Environment.ProcessorCount; ++i) {
			this._threadPool[i] = new Thread(new ThreadStart(this._worker));
		}
	}
	
	public void SetDomain(string domain) {
		this._domain = domain;
		this._isSpecificDomain = true;
	}
	
	public void ClearDomain() => this._isSpecificDomain = false;

	public void SetDepth(int x) => this._depth = x;

	public void Crawl() {
		this.StartCrawl();
		this.BlockUntilFinish();
	}

	public void StartCrawl() {
		foreach (Thread thread in this._threadPool) {
			thread.Start();
		}
		int cnt = this._urls.Count;
		this._count = cnt;
		for (int i = 0; i < cnt; ++i)
			this._queueSemaphore.Release();
	}

	public void BlockUntilFinish() {
		while (true) {
			lock (this._finishCV) {
				Monitor.Wait(this._finishCV);
				if (this._count <= this._finishedCount)
					return;
			}
		}
	}

	public void Terminate() {
		foreach (Thread thread in this._threadPool) {
			thread.Abort();
		}
	}

	private void _worker() {
		while (true) {
			this._queueSemaphore.WaitOne();

			if (!this._urls.TryDequeue(out var current))
				continue;

			this.OnStart(this, new CrawlEventArgs(current.Url));

			string html;
			var uri = new Uri(current.Url);

			try {
				html = this.Download(uri);
				this.OnSuccess(this, new CrawlEventArgs(current.Url));
			} catch (Exception ex) {
				this.OnError(this, new CrawlEventArgs(current.Url, ex.Message));
				continue;
			}
			
			++this._count;
			
			// Only when is .html, .aspx, .jsp, then crawl
			if (true || uri.AbsolutePath.EndsWith(".html") || uri.AbsolutePath.EndsWith(".aspx") || uri.AbsolutePath.EndsWith(".jsp"))
				this.Parse(html, uri, current.Depth);

			lock (_finishedCountMutex) {
				++this._finishedCount;
			}

			lock (this._finishCV) {
				Monitor.Pulse(this._finishCV);
			}
		}
	}

	private string Download(Uri uri) {
		var webClient = new WebClientRedirect();
		webClient.Encoding = Encoding.UTF8;
		
		string html = webClient.DownloadString(uri.AbsoluteUri);

		string fileName = uri.Segments[^1];
		while (fileName.EndsWith("\\") || fileName.EndsWith("/"))
			fileName = fileName[..^1];
		
		File.WriteAllText(fileName, html, Encoding.UTF8);
		return html;
	}

	private void Parse(string html, Uri baseUrl, int depth) {
		var strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
		MatchCollection matches = new Regex(strRef).Matches(html);
		foreach (Match match in matches) {
			strRef = match.Value[(match.Value.IndexOf('=') + 1)..].Trim('"', '\"', '#', '>');
			if (string.IsNullOrWhiteSpace(strRef)) continue;
			Uri uri = strRef.StartsWith("http://") || strRef.StartsWith("https://") ? new Uri(strRef) : new Uri(baseUrl, strRef);
			if ((this._isSpecificDomain && !uri.Host.EndsWith(this._domain)) || this._vis.Contains(uri.AbsoluteUri) || 1 + depth >= this._depth) continue;
			this._urls.Enqueue(new UrlInfo(uri.AbsoluteUri, 1 + depth));
			this._queueSemaphore.Release();
			lock (this._finishedCountMutex) {
				++this._finishedCount;
			}
		}
	}
}
