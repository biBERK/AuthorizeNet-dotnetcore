using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
    public class ChargeCreditCard
    {
        [JsonProperty(PropertyName = "createTransactionRequest")]
        public CreateTransactionRequest CreateTransactionRequest { get; set; }
    }
}