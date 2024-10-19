using AdapterServiceIntegration.Adapters;
using AdapterServiceIntegration.Client;
using AdapterServiceIntegration.Services;

namespace AdapterServiceIntegration
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("[Main] Starting payment process...");

            // External service initialized
            var externalService = new ExternalPaymentService();
            Console.WriteLine("[Main] ExternalPaymentService initialized.");

            // Adapter: The client works with USD, but the external service now uses EUR
            var paymentAdapter = new PaymentServiceAdapter(externalService, "USD", "EUR");
            Console.WriteLine("[Main] PaymentServiceAdapter created (converts USD to EUR).");

            // Client using the adapter
            var client = new PaymentClient(paymentAdapter);
            Console.WriteLine("[Main] PaymentClient initialized with adapter.");

            // Make a payment (the adapter will handle the currency conversion)
            client.MakePayment(100.0m);

            Console.WriteLine("[Main] Payment process completed.");
        }
    }
}