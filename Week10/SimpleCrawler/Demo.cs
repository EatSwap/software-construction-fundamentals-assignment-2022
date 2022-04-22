﻿namespace SimpleCrawler; 

public class Demo {
	private static void Main(string[] args) {
		var startUrl = "https://www.cnblogs.com/dstang2000/";
		if (args.Length >= 1) startUrl = args[0];
		
		var myCrawler = new Crawler(startUrl);
		myCrawler.SetDomain("cnblogs.com");
		new Thread(myCrawler.Crawl).Start();
	}
}