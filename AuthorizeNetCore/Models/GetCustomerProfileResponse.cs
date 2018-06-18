using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
	public class GetCustomerProfileResponse : BaseResponse
	{
		[JsonProperty(PropertyName = "profile")]
		public GetCustomerProfile CustomerProfile { get; set; }
	}
}