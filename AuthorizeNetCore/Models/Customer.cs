using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
    public class Customer
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
    }
}