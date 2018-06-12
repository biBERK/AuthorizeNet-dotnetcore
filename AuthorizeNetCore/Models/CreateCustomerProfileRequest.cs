using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
	public class CreateCustomerProfileRequest
    {
		[JsonProperty(PropertyName = "createCustomerProfileRequest")]
		public CreateCustomerProfileTransactionRequest CustomerProfileTransactionRequest { get; set; }
	}
}
