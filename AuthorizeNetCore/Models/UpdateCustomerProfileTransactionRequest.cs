using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
	public class UpdateCustomerProfileTransactionRequest
	{
		[JsonProperty(PropertyName = "merchantAuthentication")]
		public MerchantAuthentication MerchantAuthentication { get; set; }

		[JsonProperty(PropertyName = "refId")]
		public string ReferenceId { get; set; }

		[JsonProperty(PropertyName = "profile")]
		public UpdateCustomerProfile CustomerProfile { get; set; }
	}
}
