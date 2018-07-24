using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
	public class Order
    {
		[JsonProperty(PropertyName = "invoiceNumber")]
		public string InvoiceNumber { get; set; }
		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }
	}
}
