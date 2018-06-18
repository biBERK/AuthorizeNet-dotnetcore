using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
	public class UpdateCustomerPaymentProfileTransactionRequest
	{
		[JsonProperty(PropertyName = "merchantAuthentication")]
		public MerchantAuthentication MerchantAuthentication { get; set; }

		[JsonProperty(PropertyName = "refId")]
		public string ReferenceId { get; set; }

		[JsonProperty(PropertyName = "customerProfileId")]
		public string CustomerProfileId { get; set; }

		[JsonProperty(PropertyName = "paymentProfile")]
		public UpdateCustomerPaymentProfile CustomerPaymentProfile { get; set; }
	}
}
