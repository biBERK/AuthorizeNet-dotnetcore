using AuthorizeNetCore.Models;
using System.Threading.Tasks;

namespace AuthorizeNetCore
{
	public class CustomerProfile
	{
		private readonly string _authorizeNetUrl;
		private readonly string _apiLoginId;
		private readonly string _transactionKey;

		public CustomerProfile(string authorizeNetUrl, string apiLoginId, string transactionKey)
		{
			_authorizeNetUrl = authorizeNetUrl;
			_apiLoginId = apiLoginId;
			_transactionKey = transactionKey;
		}

		public async Task<CreateCustomerProfileResponse> CreateAsync(CreateCustomerProfileRequest createCustomerProfileRequest)
		{
			return await new AuthorizeNetResult(_authorizeNetUrl).PostAsync<CreateCustomerProfileRequest, CreateCustomerProfileResponse>(createCustomerProfileRequest);

		}

		public async Task<CreateCustomerProfileResponse> CreateAsync(string referenceId, string customerId, string email, string description)
		{
			// Build the request
			var createCustomerProfileRequest = new CreateCustomerProfileRequest
			{
				CustomerProfileTransactionRequest = new CreateCustomerProfileTransactionRequest
				{
					MerchantAuthentication = new MerchantAuthentication
					{
						LoginId = _apiLoginId,
						TransactionKey = _transactionKey
					},
					ReferenceId = referenceId,
					CustomerProfile = new CreateCustomerProfile
					{
						Email = email,
						MerchantCustomerId = customerId,
						Description = description
					}
				}
			};

			return await CreateAsync(createCustomerProfileRequest);
		}

		public async Task<GetCustomerProfileResponse> GetAsync(GetCustomerProfileRequest getCustomerProfileRequest)
		{
			return await new AuthorizeNetResult(_authorizeNetUrl).PostAsync<GetCustomerProfileRequest, GetCustomerProfileResponse>(getCustomerProfileRequest);
		}

		public async Task<GetCustomerProfileResponse> GetAsync(string referenceId, string customerProfileId, bool unmaskExpDate)
		{
			var getCustomerProfileRequest = new GetCustomerProfileRequest
			{
				GetProfileTransactionRequest = new GetProfileTransactionRequest
				{
					MerchantAuthentication = new MerchantAuthentication
					{
						LoginId = _apiLoginId,
						TransactionKey = _transactionKey
					},
					ReferenceId = referenceId,
					CustomerProfileId = customerProfileId,
					UnmaskExpirationDate = unmaskExpDate
				}
			};

			return await GetAsync(getCustomerProfileRequest);
		}

		public async Task<UpdateCustomerProfileResponse> PostAsync(UpdateCustomerProfileRequest updateCustomerProfileRequest)
		{
			return await new AuthorizeNetResult(_authorizeNetUrl).PostAsync<UpdateCustomerProfileRequest, UpdateCustomerProfileResponse>(updateCustomerProfileRequest);
		}

		public async Task<UpdateCustomerProfileResponse> PostAsync(string referenceId, Models.UpdateCustomerProfile customerProfile)
		{
			var updateCustomerProfileRequest = new UpdateCustomerProfileRequest
			{
				ProfileTransactionRequest = new UpdateCustomerProfileTransactionRequest
				{
					MerchantAuthentication = new MerchantAuthentication
					{
						LoginId = _apiLoginId,
						TransactionKey = _transactionKey
					},
					CustomerProfile = customerProfile,
					ReferenceId = referenceId
				}
			};

			return await PostAsync(updateCustomerProfileRequest);
		}
	}
}
