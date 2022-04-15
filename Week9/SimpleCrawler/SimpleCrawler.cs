namespace SimpleCrawler;

using System.Collections;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

public class SimpleCrawler {
	private int count;
	private readonly Queue<string> urls = new();
	
	public SimpleCrawler(params string[] u) {
		this.count = 0;
		foreach (var url in u) {
			this.urls.Enqueue(url);
		}
	}

	public void Crawl() {
		Console.WriteLine("开始爬行了.... ");
		while (this.urls.Count > 0) {
			string current = this.urls.Dequeue();

			if (this.count > 10) break;
			Console.WriteLine("爬行" + current + "页面!");
			string html = this.DownLoad(current);
			++this.count;
			this.Parse(html);
			Console.WriteLine("爬行结束");
		}
	}

	public string DownLoad(string url) {
		try {
			var webClient = new WebClient();
			webClient.Encoding = Encoding.UTF8;
			string html = webClient.DownloadString(url);
			var fileName = this.count.ToString();
			File.WriteAllText(fileName, html, Encoding.UTF8);
			return html;
		} catch (Exception ex) {
			Console.WriteLine(ex.Message);
			return "";
		}
	}

	private void Parse(string html) {
		var strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
		MatchCollection matches = new Regex(strRef).Matches(html);
		foreach (Match match in matches) {
			strRef = match.Value[(match.Value.IndexOf('=') + 1)..].Trim('"', '\"', '#', '>');
			if (!string.IsNullOrWhiteSpace(strRef) && strRef.StartsWith("http"))
				this.urls.Enqueue(strRef);
		}
	}
}