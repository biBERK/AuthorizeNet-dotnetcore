using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
	public class UpdateCustomerPaymentProfileRequest
	{
		[JsonProperty(PropertyName = "updateCustomerPaymentProfileRequest")]
		public UpdateCustomerPaymentProfileTransactionRequest PaymentProfileTransactionRequest { get; set; }
	}

}
