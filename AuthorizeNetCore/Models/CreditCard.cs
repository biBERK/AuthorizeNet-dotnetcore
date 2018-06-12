using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
    public class CreditCard
    {
        [JsonProperty(PropertyName = "cardNumber")]
        public string CardNumber { get; set; }
        [JsonProperty(PropertyName = "expirationDate")]
        public string ExpirationDate { get; set; }
        //[JsonProperty(PropertyName = "cardCode")]
        //public string CardCode { get; set; }
    }
}