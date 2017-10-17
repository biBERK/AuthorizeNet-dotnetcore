﻿using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
    public class TransactionRequest
    {
        [JsonProperty(PropertyName = "transactionType")]
        public string TransactionType { get; set; }
        [JsonProperty(PropertyName = "amount")]
        public string Amount { get; set; }
        [JsonProperty(PropertyName = "payment")]
        public Payment Payment { get; set; }
        [JsonProperty(PropertyName = "lineItems")]
        public Lineitems LineItems { get; set; }
        [JsonProperty(PropertyName = "tax")]
        public Tax Tax { get; set; }
        [JsonProperty(PropertyName = "duty")]
        public Duty Duty { get; set; }
        [JsonProperty(PropertyName = "shipping")]
        public Shipping Shipping { get; set; }
        [JsonProperty(PropertyName = "poNumber")]
        public string PoNumber { get; set; }
        [JsonProperty(PropertyName = "customer")]
        public Customer Customer { get; set; }
        [JsonProperty(PropertyName = "billTo")]
        public Billto BillTo { get; set; }
        [JsonProperty(PropertyName = "shipTo")]
        public Shipto ShipTo { get; set; }
        [JsonProperty(PropertyName = "customerIP")]
        public string CustomerIP { get; set; }
        [JsonProperty(PropertyName = "transactionSettings")]
        public Transactionsettings TransactionSettings { get; set; }
        [JsonProperty(PropertyName = "userFields")]
        public Userfields UserFields { get; set; }
    }
}