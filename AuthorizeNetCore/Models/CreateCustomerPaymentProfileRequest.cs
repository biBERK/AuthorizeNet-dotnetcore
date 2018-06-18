using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
	public class CreateCustomerPaymentProfileRequest
	{
		[JsonProperty(PropertyName = "createCustomerPaymentProfileRequest")]
		public CreateCustomerPaymentProfileTransactionRequest CustomerPaymentProfileTransactionRequest { get; set; }

	}
}
