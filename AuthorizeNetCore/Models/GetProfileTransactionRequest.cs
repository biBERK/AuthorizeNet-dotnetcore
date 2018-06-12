using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
	public class GetProfileTransactionRequest
    {
		[JsonProperty(PropertyName = "merchantAuthentication")]
		public MerchantAuthentication MerchantAuthentication { get; set; }

		[JsonProperty(PropertyName = "refId")]
		public string ReferenceId { get; set; }

		[JsonProperty(PropertyName = "customerProfileId")]
		public string CustomerProfileId { get; set; }

		//[JsonProperty(PropertyName = "merchantCustomerId")]
		//public string MerchantCustomerId { get; set; }

		//[JsonProperty(PropertyName = "email")]
		//public string Email { get; set; }

		[JsonProperty(PropertyName = "unmaskExpirationDate")]
		public bool UnmaskExpirationDate { get; set; }

	}
}
