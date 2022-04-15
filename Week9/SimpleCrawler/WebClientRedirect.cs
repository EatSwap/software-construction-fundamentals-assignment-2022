namespace SimpleCrawler;

using System.Net;

internal class WebClientRedirect : WebClient {
	protected override WebResponse GetWebResponse(WebRequest request) {
		(request as HttpWebRequest)!.AllowAutoRedirect = true;
		return base.GetWebResponse(request);
	}
}