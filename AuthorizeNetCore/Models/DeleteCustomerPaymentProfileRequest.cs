using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
	public class DeleteCustomerPaymentProfileRequest
	{
		[JsonProperty(PropertyName = "deleteCustomerPaymentProfileRequest")]
		public DeletePaymentProfileTransactionRequest DeletePaymentProfileTransactionRequest { get; set; }
	}
}
