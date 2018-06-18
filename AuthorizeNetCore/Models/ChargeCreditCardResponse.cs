using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
	public class ChargeCreditCardResponse : BaseResponse
	{

		[JsonProperty(PropertyName = "transactionResponse")]
		public TransactionResponse TransactionResponse { get; set; }

	}
}