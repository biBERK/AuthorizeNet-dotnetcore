using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
	public class GetCustomerPaymentProfile
	{
		[JsonProperty(PropertyName = "defaultPaymentProfile")]
		public string DefaultPaymentProfile { get; set; }

		[JsonProperty(PropertyName = "customerProfileId")]
		public string CustomerProfileId { get; set; }

		[JsonProperty(PropertyName = "customerPaymentProfile")]
		public string CustomerPaymentProfileId { get; set; }

		[JsonProperty(PropertyName = "billTo")]
		public CustomerContact BillTo { get; set; }

		[JsonProperty(PropertyName = "payment")]
		public GetPayment Payment { get; set; }
	}
}
