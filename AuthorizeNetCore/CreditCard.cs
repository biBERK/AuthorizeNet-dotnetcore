using AuthorizeNetCore.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
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
            // Serialize the ChargeCreditCardRequest object
            var stringContent = new StringContent(JsonConvert.SerializeObject(chargeCreditCardRequest), Encoding.UTF8, "application/json");

            // Connect to Authorize.net
            var httpClient = new HttpClient();
            var response = await httpClient.PostAsync(_authorizeNetUrl, stringContent);

            // If response is not successful, return appropriate transaction response
            if (!response.IsSuccessStatusCode)
            {
                var resultMessage = new ResultMessage { Code = response.StatusCode.ToString(), Text = response.ReasonPhrase };
                var resultMessages = new ResultMessage[1];
                resultMessages[0] = resultMessage;
                return new ChargeCreditCardResponse { Results = new Results { ResultCode = "Error", ResultMessages = resultMessages } };
            }

            // Deserialize the response content
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ChargeCreditCardResponse>(json);
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
                        BillTo = new CustomerContact(),
                        Customer = new Customer { Id = customerId },
                        CustomerIP = customerIpAddress,
                        Duty = new Duty(),
                        LineItems = new LineItems { LineItem = new LineItem[0] },
                        Payment = new Payment
                        {
                            OpaqueData = new OpaqueData { NonceValue = nonce }
                        },
                        PoNumber = "",
                        Shipping = new Shipping(),
                        ShipTo = new CustomerContact(),
                        Tax = new Tax(),
                        TransactionSettings = new TransactionSettings { Setting = new Setting[0] },
                        UserFields = new UserFields { UserField = new UserField[0] }
                    }
                }
            };

            return await ChargeAsync(chargeCreditCardRequest);
        }

        public string ChargeCreditCardRequestString(string nonce, string referenceId, decimal amount, string customerId, string customerIpAddress)
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
                        BillTo = new CustomerContact(),
                        Customer = new Customer { Id = customerId },
                        CustomerIP = customerIpAddress,
                        Duty = new Duty(),
                        LineItems = new LineItems { LineItem = new LineItem[0] },
                        Payment = new Payment
                        {
                            OpaqueData = new OpaqueData { NonceValue = nonce }
                        },
                        PoNumber = "",
                        Shipping = new Shipping(),
                        ShipTo = new CustomerContact(),
                        Tax = new Tax(),
                        TransactionSettings = new TransactionSettings { Setting = new Setting[0] },
                        UserFields = new UserFields { UserField = new UserField[0] }
                    }
                }
            };

            return JsonConvert.SerializeObject(chargeCreditCardRequest);
        }
        }
}