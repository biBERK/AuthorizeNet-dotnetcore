using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
	public class CreateCustomerProfileRequest
    {
		[JsonProperty(PropertyName = "createCustomerProfileRequest")]
		public CreateCustomerProfileTransactionRequest CustomerProfileTransactionRequest { get; set; }
	}

	public class CreateCustomerProfileFromTransactionRequest
	{
		[JsonProperty(PropertyName = "createCustomerProfileFromTransactionRequest")]
		public CustomerProfileGenerateTransactionRequest CustomerProfileGenerateTransactionRequest { get; set; }
	}

	public class CustomerProfileGenerateTransactionRequest
	{
		[JsonProperty(PropertyName = "merchantAuthentication")]
		public MerchantAuthentication MerchantAuthentication { get; set; }

		[JsonProperty(PropertyName = "refId")]
		public string ReferenceId { get; set; }

		[JsonProperty(PropertyName = "transId")]
		public string TransactionId { get; set; }

		[JsonProperty(PropertyName = "customer")]
		public CreateCustomerProfile CustomerProfile { get; set; }

	}
}
