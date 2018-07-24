using AuthorizeNetCore.Models;
using System.Threading.Tasks;

namespace AuthorizeNetCore
{
	public class CreditCard
	{
		private readonly string _authorizeNetUrl;
		private readonly string _apiLoginId;
		private readonly string _transactionKey;

		public CreditCard(string authorizeNetUrl, string apiLoginId, string transactionKey)
		{
			_authorizeNetUrl = authorizeNetUrl;
			_apiLoginId = apiLoginId;
			_transactionKey = transactionKey;
		}

		public async Task<ChargeCreditCardResponse> ChargeAsync(ChargeCreditCardRequest chargeCreditCardRequest)
		{
			return await new AuthorizeNetResult(_authorizeNetUrl).PostAsync<ChargeCreditCardRequest, ChargeCreditCardResponse>(chargeCreditCardRequest);
		}

		public async Task<ChargeCreditCardResponse> ChargeAsync(string nonce, string referenceId, decimal amount, string customerId, string customerIpAddress)
		{
			// Build the request
			var chargeCreditCardRequest = new ChargeCreditCardRequest
			{
				CreateTransactionRequest = new CreateTransactionRequest
				{
					MerchantAuthentication = new MerchantAuthentication { LoginId = _apiLoginId, TransactionKey = _transactionKey },
					ReferenceId = referenceId,
					TransactionRequest = new TransactionRequest
					{
						Amount = amount.ToString(),
						Customer = new Customer { Id = customerId },
						CustomerIP = customerIpAddress,
						Duty = new Duty(),
						Payment = new Payment
						{
							OpaqueData = new OpaqueData { NonceValue = nonce }
						},
						Shipping = new Shipping(),
						Tax = new Tax()
					}
				}
			};

			return await ChargeAsync(chargeCreditCardRequest);
		}

		public async Task<ChargeCreditCardResponse> ChargeAsync(string nonce, string referenceId, decimal amount, string customerId, string customerIpAddress, string invoiceId)
		{
			// Build the request
			var chargeCreditCardRequest = new ChargeCreditCardRequest
			{
				CreateTransactionRequest = new CreateTransactionRequest
				{
					MerchantAuthentication = new MerchantAuthentication { LoginId = _apiLoginId, TransactionKey = _transactionKey },
					ReferenceId = referenceId,
					TransactionRequest = new TransactionRequest
					{
						Amount = amount.ToString(),
						Customer = new Customer { Id = customerId },
						CustomerIP = customerIpAddress,
						Duty = new Duty(),
						Payment = new Payment
						{
							OpaqueData = new OpaqueData { NonceValue = nonce }
						},
						Order = new Order
						{
							InvoiceNumber = invoiceId
						},
						Shipping = new Shipping(),
						Tax = new Tax()
					}
				}
			};

			return await ChargeAsync(chargeCreditCardRequest);
		}
	}
}