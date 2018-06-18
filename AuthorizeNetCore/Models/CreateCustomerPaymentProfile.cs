using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
	public class CreateCustomerPaymentProfile
	{
		//[JsonProperty(PropertyName = "customerType")]
		//public string CustomerType { get; set; }

		[JsonProperty(PropertyName = "billTo")]
		public CustomerContact BillTo { get; set; }

		[JsonProperty(PropertyName = "payment")]
		public Payment Payment { get; set; }

		[JsonProperty(PropertyName = "defaultPaymentProfile")]
		public bool DefaultPaymentProfile { get; set; }

	}
}
