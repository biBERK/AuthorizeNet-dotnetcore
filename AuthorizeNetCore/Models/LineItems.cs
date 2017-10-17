using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
    public class LineItems
    {
        [JsonProperty(PropertyName = "lineItem")]
        public LineItem[] LineItem { get; set; }
    }
}