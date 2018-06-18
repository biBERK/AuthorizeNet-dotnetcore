using AuthorizeNetCore.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizeNetCore
{
	public class AuthorizeNetResult
    {
		private readonly string _authorizeNetUrl;

		public AuthorizeNetResult(string authorizeNetUrl)
		{
			_authorizeNetUrl = authorizeNetUrl;
		}

		public async Task<TResponse> PostAsync<TRequest, TResponse>(TRequest requestDTO)
		{

			//Before we continue, ensure T objects implements appropriate base classes
			var responseType = typeof(TResponse);

			if (!responseType.IsSubclassOf(typeof(BaseResponse)))
			{
				throw new MissingMemberException($"{responseType.Name} is not a subclass of BaseResponse");
			}


			// Serialize the object
			var stringContent = new StringContent(JsonConvert.SerializeObject(requestDTO), Encoding.UTF8, "application/json");


			// Connect to Authorize.net
			var httpClient = new HttpClient();
			var response = await httpClient.PostAsync(_authorizeNetUrl, stringContent);


			// If response is not successful, return appropriate transaction response
			if (!response.IsSuccessStatusCode)
			{
				// store results
				var resultMessage = new ResultMessage
				{
					Code = response.StatusCode.ToString(),
					Text = response.ReasonPhrase
				};

				var resultMessages = new ResultMessage[1];
				resultMessages[0] = resultMessage;

				// get a new instance of T
				var responseDTO = (TResponse)Activator.CreateInstance(responseType);

				// set the Result Property of TResponse
				var resultProp = responseType.GetProperty("Results");
				resultProp.SetValue(responseDTO, new Results
				{
					ResultCode = "Error",
					ResultMessages = resultMessages
				});

				return responseDTO;
			}

			// Deserialize the response content
			var json = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<TResponse>(json);
		}
	}
}
