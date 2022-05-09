namespace OrderWeb.Base;

public sealed class HttpResponse<T> {
	public int code { get; set; }

	public string message { get; set; }

	public T? data { get; set; }
	
	private HttpResponse() {
		// Prevent direct usage
	}

	public static HttpResponse<T> Success(T? data) {
		return new HttpResponse<T> {
			code = 0,
			message = "",
			data = data
		};
	}

	public static HttpResponse<object> Success() {
		return new HttpResponse<object> {
			code = 0,
			message = "",
			data = null
		};
	}

	public static HttpResponse<T> Error() {
		return new HttpResponse<T> {
			code = -1,
			message = "",
			data = default
		};
	}
	
	public static HttpResponse<T> ErrorWithMessage(string message) {
		return new HttpResponse<T> {
			code = -1,
			message = message,
			data = default
		};
	}
	
	public static HttpResponse<T> ErrorWithMessage(string message, T? data) {
		return new HttpResponse<T> {
			code = -1,
			message = message,
			data = data
		};
	}
	
	public static HttpResponse<T> ErrorWithCode(int code) {
		return new HttpResponse<T> {
			code = code,
			message = "",
			data = default
		};
	}
	
	
	public static HttpResponse<T> ErrorWithCodeMessage(int code, string message = "") {
		return new HttpResponse<T> {
			code = code,
			message = message,
			data = default
		};
	}
	
	public static HttpResponse<T> ErrorWithCodeMessage(int code, string message, T? data) {
		return new HttpResponse<T> {
			code = code,
			message = message,
			data = data
		};
	}
}