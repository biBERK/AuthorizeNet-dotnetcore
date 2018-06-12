using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
	public class CreateCustomerProfileTransactionRequest
    {
		[JsonProperty(PropertyName = "merchantAuthentication")]
		public MerchantAuthentication MerchantAuthentication { get; set; }

		[JsonProperty(PropertyName = "refId")]
		public string ReferenceId { get; set; }

		[JsonProperty(PropertyName = "profile")]
		public CreateCustomerProfile CustomerProfile { get; set; }
	}
}
