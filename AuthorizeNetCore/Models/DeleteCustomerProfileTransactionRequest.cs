using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
	public class DeleteCustomerProfileTransactionRequest
	{
		[JsonProperty(PropertyName = "merchantAuthentication")]
		public MerchantAuthentication MerchantAuthentication { get; set; }

		[JsonProperty(PropertyName = "refId")]
		public string ReferenceId { get; set; }

		[JsonProperty(PropertyName = "customerProfileId")]
		public string CustomerProfileId { get; set; }
	}
}