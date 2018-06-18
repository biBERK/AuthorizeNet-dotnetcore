using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
	public class UpdateCustomerPaymentProfileResponse : BaseResponse
	{
		[JsonProperty(PropertyName = "validationDirectResponse")]
		public string ValidationDirectResponse { get; set; }

		[JsonProperty(PropertyName = "defaultPaymentProfile")]
		public string DefaultPaymentProfile { get; set; }
	}
}