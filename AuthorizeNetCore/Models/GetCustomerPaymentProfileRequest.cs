using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
	public class GetCustomerPaymentProfileRequest
    {
		[JsonProperty(PropertyName = "getCustomerPaymentProfileRequest")]
		public GetCustomerPaymentProfileTransactionRequest CustomerPaymentProfileTransactionRequest { get; set; }
	}
}
