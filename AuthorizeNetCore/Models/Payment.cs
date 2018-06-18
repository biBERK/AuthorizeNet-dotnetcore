using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
    public class Payment
    {

		[JsonProperty(PropertyName = "opaqueData")]
        public OpaqueData OpaqueData { get; set; }
    }

	public class GetPayment
	{
		[JsonProperty(PropertyName = "creditCard")]
		public CreditCard CreditCard { get; set; }

		[JsonProperty(PropertyName = "opaqueData")]
		public OpaqueData OpaqueData { get; set; }
	}
}