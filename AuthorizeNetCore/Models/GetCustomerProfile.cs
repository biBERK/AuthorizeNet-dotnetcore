﻿using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
	public class GetCustomerProfile
    {
		[JsonProperty(PropertyName = "merchantCustomerId")]
		public string MerchantCustomerId { get; set; }

		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

		[JsonProperty(PropertyName = "customerProfileId")]
		public string CustomerProfileId { get; set; }

		[JsonProperty(PropertyName = "email")]
		public string Email { get; set; }		
	}
}
