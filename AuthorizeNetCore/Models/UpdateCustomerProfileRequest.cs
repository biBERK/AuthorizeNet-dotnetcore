using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
	public class UpdateCustomerProfileRequest
    {
		[JsonProperty(PropertyName = "updateCustomerProfileRequest")]
		public UpdateCustomerProfileTransactionRequest ProfileTransactionRequest { get; set; }
	}	
}
