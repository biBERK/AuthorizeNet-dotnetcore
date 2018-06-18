using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
	public class CreateCustomerPaymentProfileResponse : BaseResponse
	{
		[JsonProperty(PropertyName = "customerPaymentProfileId")]
		public string CustomerPaymentProfileId { get; set; }

		[JsonProperty(PropertyName = "validationDirectResponse")]
		public string ValidationDirectResponse { get; set; }

		[JsonProperty(PropertyName = "defaultPaymentProfile")]
		public string DefaultPaymentProfile { get; set; }
	}
}