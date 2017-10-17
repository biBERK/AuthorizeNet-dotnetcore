using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
    public class UserFields
    {
        [JsonProperty(PropertyName = "userField")]
        public UserField[] UserField { get; set; }
    }
}