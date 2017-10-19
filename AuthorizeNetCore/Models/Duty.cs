using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
    public class Duty
    {
        [JsonProperty(PropertyName = "amount")]
        public string Amount { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        public Duty()
        {
            Amount = "0";
        }
    }
}