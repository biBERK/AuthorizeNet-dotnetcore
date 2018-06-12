using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
	public class CustomerContact
	{
		[JsonProperty(PropertyName = "firstName")]
		public string FirstName { get; set; }
		[JsonProperty(PropertyName = "lastName")]
		public string LastName { get; set; }
		[JsonProperty(PropertyName = "company")]
		public string Company { get; set; }
		[JsonProperty(PropertyName = "address")]
		public string Address { get; set; }
		[JsonProperty(PropertyName = "city")]
		public string City { get; set; }
		[JsonProperty(PropertyName = "state")]
		public string State { get; set; }
		[JsonProperty(PropertyName = "zip")]
		public string Zip { get; set; }
		[JsonProperty(PropertyName = "country")]
		public string Country { get; set; }
		[JsonProperty(PropertyName = "phoneNumber")]
		public string PhoneNumber { get; set; }
	
	}
}