using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
    public class UserField
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
    }
}