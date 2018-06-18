using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
	public class GetCustomerPaymentProfileResponse : BaseResponse
    {
		[JsonProperty(PropertyName = "paymentProfile")]
		public GetCustomerPaymentProfile CustomerPaymentProfile { get; set; }
    }

}
