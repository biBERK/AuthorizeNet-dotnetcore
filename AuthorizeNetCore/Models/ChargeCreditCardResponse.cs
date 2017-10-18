﻿using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
    public class ChargeCreditCardResponse
    {
        public bool IsSuccessful
        {
            get {
                if (Results == null)
                    return false;
                return Results.ResultCode.ToUpper() == "OK";
            }
        }
        [JsonProperty(PropertyName = "refId")]
        public string ReferenceId { get; set; }
        [JsonProperty(PropertyName = "transactionResponse")]
        public TransactionResponse TransactionResponse { get; set; }
        [JsonProperty(PropertyName = "messages")]
        public Results Results { get; set; }
    }
}