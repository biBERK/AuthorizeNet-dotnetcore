using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
	public class GetCustomerProfileRequest
	{

		[JsonProperty(PropertyName = "getCustomerProfileRequest")]
		public GetProfileTransactionRequest GetProfileTransactionRequest { get; set; }
	}
}
