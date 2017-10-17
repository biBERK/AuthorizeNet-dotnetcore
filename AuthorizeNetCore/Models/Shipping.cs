using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
    public class Shipping
    {
        [JsonProperty(PropertyName = "amount")]
        public string Amount { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}