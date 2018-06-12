using AuthorizeNetCore.Models;
using System.Threading.Tasks;

namespace AuthorizeNetCore
{
	public class CustomerPaymentProfile
	{
		private readonly string _authorizeNetUrl;
		private readonly string _apiLoginId;
		private readonly string _transactionKey;

		public CustomerPaymentProfile(string authorizeNetUrl, string apiLoginId, string transactionKey)
		{
			_authorizeNetUrl = authorizeNetUrl;
			_apiLoginId = apiLoginId;
			_transactionKey = transactionKey;
		}

		public async Task<CreateCustomerPaymentProfileResponse> CreateAsync(CreateCustomerPaymentProfileRequest createCustomerPaymentProfileRequest)
		{
			return await new AuthorizeNetResult(_authorizeNetUrl).PostAsync<CreateCustomerPaymentProfileRequest, CreateCustomerPaymentProfileResponse>(createCustomerPaymentProfileRequest);
		}

		public async Task<CreateCustomerPaymentProfileResponse> CreateAsync(string customerProfileId, string nonce, string referenceId, bool defaultProfile)
		{
			var createCustomerPaymentProfileRequest = new CreateCustomerPaymentProfileRequest
			{
				CustomerPaymentProfileTransactionRequest = new CreateCustomerPaymentProfileTransactionRequest
				{
					MerchantAuthentication = new MerchantAuthentication
					{
						LoginId = _apiLoginId,
						TransactionKey = _transactionKey
					},
					CustomerProfileId = customerProfileId,
					ReferenceId = referenceId,
					CustomerPaymentProfile = new Models.CreateCustomerPaymentProfile
					{
						Payment = new Payment
						{
							OpaqueData = new OpaqueData { NonceValue = nonce }
						},
						BillTo = new CustomerContact(),
						DefaultPaymentProfile = defaultProfile
					}
				}
			};

			return await CreateAsync(createCustomerPaymentProfileRequest);
		}

		public async Task<GetCustomerPaymentProfileResponse> GetAsync(GetCustomerPaymentProfileRequest getCustomerPaymentProfileRequest)
		{
			return await new AuthorizeNetResult(_authorizeNetUrl).PostAsync<GetCustomerPaymentProfileRequest, GetCustomerPaymentProfileResponse>(getCustomerPaymentProfileRequest);
		}

		public async Task<GetCustomerPaymentProfileResponse> GetAsync(string referenceId, string customerProfileId, string customerPaymentId, bool unmaskExpDate)
		{
			var getCustomerPaymentProfileRequest = new GetCustomerPaymentProfileRequest
			{
				CustomerPaymentProfileTransactionRequest = new GetCustomerPaymentProfileTransactionRequest
				{
					MerchantAuthentication = new MerchantAuthentication
					{
						LoginId = _apiLoginId,
						TransactionKey = _transactionKey
					},
					ReferenceId = referenceId,
					CustomerProfileId = customerProfileId,
					CustomerPaymentProfileId = customerPaymentId,
					UnmaskExpirationDate = unmaskExpDate
				}
			};

			return await GetAsync(getCustomerPaymentProfileRequest);
		}

		public async Task<UpdateCustomerPaymentProfileResponse> PostAsync(UpdateCustomerPaymentProfileRequest updateCustomerPaymentProfileRequest)
		{
			return await new AuthorizeNetResult(_authorizeNetUrl).PostAsync<UpdateCustomerPaymentProfileRequest, UpdateCustomerPaymentProfileResponse>(updateCustomerPaymentProfileRequest);
		}

		public async Task<UpdateCustomerPaymentProfileResponse> PostAsync(string customerProfileId, string referenceId, Models.UpdateCustomerPaymentProfile customerPaymentProfile)
		{
			var updateCustomerPaymentProfileRequest = new UpdateCustomerPaymentProfileRequest
			{
				PaymentProfileTransactionRequest = new UpdateCustomerPaymentProfileTransactionRequest
				{
					MerchantAuthentication = new MerchantAuthentication
					{
						LoginId = _apiLoginId,
						TransactionKey = _transactionKey
					},
					CustomerProfileId = customerProfileId,
					ReferenceId = referenceId,
					CustomerPaymentProfile = customerPaymentProfile
				}
			};

			return await PostAsync(updateCustomerPaymentProfileRequest);
		}

		public async Task<DeleteCustomerPaymentProfileResponse> DeleteAsync(DeletePaymentProfileTransactionRequest deleteCustomerPaymentProfileRequest)
		{
			return await new AuthorizeNetResult(_authorizeNetUrl).PostAsync<DeletePaymentProfileTransactionRequest, DeleteCustomerPaymentProfileResponse>(deleteCustomerPaymentProfileRequest);
		}

		public async Task<DeleteCustomerPaymentProfileResponse> DeleteAsync(string customerPaymentProfileId, string customerProfileId, string referenceId)
		{
			var deleteCustomerPaymentProfileRequest = new DeletePaymentProfileTransactionRequest
			{
				MerchantAuthentication = new MerchantAuthentication
				{
					LoginId = _apiLoginId,
					TransactionKey = _transactionKey
				},
				CustomerPaymentProfileId = customerPaymentProfileId,
				CustomerProfileId = customerProfileId,
				ReferenceId = referenceId
			};

			return await DeleteAsync(deleteCustomerPaymentProfileRequest);
		}
	}
}
