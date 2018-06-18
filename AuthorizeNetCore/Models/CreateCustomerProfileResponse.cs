using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
	public class CreateCustomerProfileResponse : BaseResponse
	{
		[JsonProperty(PropertyName = "customerProfileId")]
		public string CustomerProfileId { get; set; }
		
		[JsonProperty(PropertyName = "customerPaymentProfileIdList")]
		public string[] CustomerPaymentProfileIds { get; set; }

		[JsonProperty(PropertyName = "validationDirectResponseList")]
		public string[] ValidationDirectResponses { get; set; }
	}
}