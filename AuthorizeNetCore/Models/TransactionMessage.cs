using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
    public class TransactionMessage
    {
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}