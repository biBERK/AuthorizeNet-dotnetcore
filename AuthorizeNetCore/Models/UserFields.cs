using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
    public class Userfields
    {
        [JsonProperty(PropertyName = "userField")]
        public UserField[] UserField { get; set; }
    }
}