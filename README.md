# Authorize.Net for .NET Core
As of the original authoring of this repository, Authorize.Net lacks a supported SDK for .NET Standard or .NET Core. A few have asked [here](https://github.com/AuthorizeNet/sdk-dotnet/issues/162) and [here](https://github.com/AuthorizeNet/sdk-dotnet/issues/196). Since we needed this support for our own internal applications, we created a very thin client to charge credit cards. Additional functionality can be requested and/or implemented via pull requests.

## Assumptions
This this client assumes the following:

1. You have cloned this repository, compiled it, and dropped the AuthorizeNetCore.dll file in your bin directory.
> At the present time, this library has not been submitted to the NuGet.org public repository.
2. You are using Authorize.Net's [AcceptJS library](https://developer.authorize.net/api/reference/features/acceptjs.html).

## Getting Started
After the library is referenced within your project, you can create a brand new `CreditCard` object by instantiating it with the Authorize.Net URL you'd like to use, the LoginId, and the TransactionKey as so:

```csharp
var creditCard = new CreditCard("https://apitest.authorize.net/xml/v1/request.api", "LOGIN_ID", "TRANSACTION_KEY");
```

Now that we have a `CreditCard` object, we can charge our card asynchronously. To do so, we can provide minimal information or a complete `ChargeCreditCardRequest` object.

> If you need to pass over line items, shipping address, or custom fields, you'll want to use the signature that accepts the `ChargeCreditCardRequest` object.

Here is the sample using the minimalistic approach:

```csharp
/// ChargeAsync(string nounce, string referenceId, decimal amount, string customerId, string customerIpAddress)
var chargeResponse = await creditCard.ChargeAsync("opaqueData_NOUNCE_Value", "YOUR_REFERENCE_ID", 99.95, "CUSTOMER_ID", "192.168.1.1")
```


<hr/>
This repository is subject to the MIT License, contained in this repository. Any biBERK team member contributions are provided AS IS, with absolutely no warranty or guarantee whatsoever. Use of the code from any repository or commit is solely at your own risk.
