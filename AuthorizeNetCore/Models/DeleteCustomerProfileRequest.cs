using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
	public class DeleteCustomerProfileRequest
	{
		[JsonProperty(PropertyName = "deleteCustomerProfileRequest")]
		public DeleteCustomerProfileTransactionRequest DeleteCustomerProfileTransactionRequest { get; set; }
	}
}
