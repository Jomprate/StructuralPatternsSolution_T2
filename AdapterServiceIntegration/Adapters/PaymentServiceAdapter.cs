using AdapterServiceIntegration.Interfaces;
using AdapterServiceIntegration.Services;

namespace AdapterServiceIntegration.Adapters
{
    public class PaymentServiceAdapter : PaymentService
    {
        private readonly ExternalPaymentService _externalService;
        private readonly string _clientCurrency; // Currency expected by the client
        private readonly string _serviceCurrency; // Currency expected by the external service

        public PaymentServiceAdapter(ExternalPaymentService externalService, string clientCurrency, string serviceCurrency)
        {
            _externalService = externalService;
            _clientCurrency = clientCurrency;
            _serviceCurrency = serviceCurrency;
        }

        public override void ProcessPayment(decimal amount)
        {
            // If the client currency and service currency differ, we simulate a conversion
            if (_clientCurrency != _serviceCurrency)
            {
                Console.WriteLine($"[PaymentServiceAdapter] Converting {amount} {_clientCurrency} to {_serviceCurrency}.");
                amount = ConvertCurrency(amount, _clientCurrency, _serviceCurrency); // Simulate conversion
            }

            // Delegate the payment processing to the external service in the appropriate currency
            Console.WriteLine($"[PaymentServiceAdapter] Adapting payment to {_serviceCurrency}.");
            _externalService.MakePayment(_serviceCurrency, amount);
        }

        private decimal ConvertCurrency(decimal amount, string fromCurrency, string toCurrency)
        {
            // Simulate a currency conversion (for demonstration purposes, we'll just return the same amount)
            // In a real-world scenario, you might call a currency conversion API here
            Console.WriteLine($"[PaymentServiceAdapter] Simulating currency conversion from {fromCurrency} to {toCurrency}.");
            return amount; // In this example, we don't actually change the amount
        }
    }
}