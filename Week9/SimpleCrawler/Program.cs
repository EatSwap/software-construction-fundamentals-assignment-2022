namespace SimpleCrawler;

using System.Collections;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

public class SimpleCrawler {
	private int count;
	private readonly Hashtable urls = new();

	private static void Main(string[] args) {
		var myCrawler = new SimpleCrawler();
		var startUrl = "http://www.cnblogs.com/dstang2000/";
		if (args.Length >= 1) startUrl = args[0];
		myCrawler.urls.Add(startUrl, false);
		new Thread(myCrawler.Crawl).Start();
	}

	private void Crawl() {
		Console.WriteLine("开始爬行了.... ");
		while (true) {
			string? current = null;
			foreach (string url in this.urls.Keys) {
				if ((bool) (this.urls[url] ?? true)) continue;
				current = url;
			}

			if (current == null || this.count > 10) break;
			Console.WriteLine("爬行" + current + "页面!");
			string html = this.DownLoad(current);
			this.urls[current] = true;
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
			strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
				.Trim('"', '\"', '#', '>');
			if (strRef.Length == 0) continue;
			this.urls[strRef] ??= false;
		}
	}
}