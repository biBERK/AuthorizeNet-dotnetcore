using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
    public class ChargeCreditCardRequest
    {
        [JsonProperty(PropertyName = "createTransactionRequest")]
        public CreateTransactionRequest CreateTransactionRequest { get; set; }
    }
}