using AuthorizeNetCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

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

        public TransactionResponse Charge(ChargeCreditCardRequest chargeCreditCardRequest)
        {
            return new TransactionResponse();
        }

        public TransactionResponse Charge(string nounce, string referenceId, decimal amount, string customerId, string customerIpAddress)
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
                            OpaqueData = new OpaqueData { NonceValue = nounce }
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

            return Charge(chargeCreditCardRequest);
        }
    }
}
