using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
    public class Setting
    {
        [JsonProperty(PropertyName = "settingName")]
        public string SettingName { get; set; }
        [JsonProperty(PropertyName = "settingValue")]
        public string SettingValue { get; set; }
    }
}