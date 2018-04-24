using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
	public class Errors
    {
		[JsonProperty(PropertyName = "errorCode")]
		public string Code { get; set; }
		[JsonProperty(PropertyName = "errorText")]
		public string Text { get; set; }

	}
}
