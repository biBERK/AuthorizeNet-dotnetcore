using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
    public class Results
    {
        [JsonProperty(PropertyName = "resultCode")]
        public string ResultCode { get; set; }
        [JsonProperty(PropertyName = "message")]
        public ResultMessage[] ResultMessages { get; set; }
    }
}