using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
    public class OpaqueData
    {
        [JsonProperty(PropertyName = "dataDescriptor")]
        public string DataDescriptor { get { return "COMMON.ACCEPT.INAPP.PAYMENT"; } }
        [JsonProperty(PropertyName = "dataValue")]
        public string NonceValue { get; set; }
    }
}