using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
    public class TransactionResponse
    {
        [JsonProperty(PropertyName = "responseCode")]
        public string ResponseCode { get; set; }
        [JsonProperty(PropertyName = "authCode")]
        public string AuthCode { get; set; }
        [JsonProperty(PropertyName = "avsResultCode")]
        public string AVSResultCode { get; set; }
        [JsonProperty(PropertyName = "cvvResultCode")]
        public string CVVResultCode { get; set; }
        [JsonProperty(PropertyName = "cavvResultCode")]
        public string CAVVResultCode { get; set; }
        [JsonProperty(PropertyName = "transId")]
        public string TransId { get; set; }
        [JsonProperty(PropertyName = "refTransID")]
        public string RefTransID { get; set; }
        [JsonProperty(PropertyName = "transHash")]
        public string TransHash { get; set; }
        [JsonProperty(PropertyName = "accountNumber")]
        public string AccountNumber { get; set; }
        [JsonProperty(PropertyName = "accountType")]
        public string AccountType { get; set; }
        [JsonProperty(PropertyName = "messages")]
        public TransactionMessage[] Messages { get; set; }
		[JsonProperty(PropertyName ="errors")]
		public Errors[] Errors { get; set; }
		[JsonProperty(PropertyName = "userFields")]
        public UserField[] UserFields { get; set; }
    }
}