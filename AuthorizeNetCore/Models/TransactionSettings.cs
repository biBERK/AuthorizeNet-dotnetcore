using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
    public class TransactionSettings
    {
        [JsonProperty(PropertyName = "settingName")]
        public Setting[] Setting { get; set; }
    }
}