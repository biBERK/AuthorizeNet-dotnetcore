using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorizeNetCore.Models
{
	public class UpdateCustomerPaymentProfile
	{
		[JsonProperty(PropertyName = "customerType")]
		public string CustomerType { get; set; }

		[JsonProperty(PropertyName = "billTo")]
		public CustomerContact BillTo { get; set; }

		[JsonProperty(PropertyName = "payment")]
		public Payment Payment { get; set; }

		[JsonProperty(PropertyName = "defaultPaymentProfile")]
		public bool DefaultPaymentProfile { get; set; }

		[JsonProperty(PropertyName = "customerPaymentProfileId")]
		public string CustomerPaymentProfileId { get; set; }

	}
}
