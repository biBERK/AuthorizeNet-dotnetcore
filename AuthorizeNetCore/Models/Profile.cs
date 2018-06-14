using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
	public class Profile
	{
		[JsonProperty(PropertyName = "createProfile")]
		public bool CreateProfile { get; set; }
	}
}
