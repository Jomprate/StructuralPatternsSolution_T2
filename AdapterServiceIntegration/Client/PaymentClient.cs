using AdapterServiceIntegration.Interfaces;

namespace AdapterServiceIntegration.Client
{
    public class PaymentClient
    {
        private readonly PaymentService _paymentService;

        public PaymentClient(PaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"[PaymentClient] Requesting payment of {amount} through PaymentService.");
            _paymentService.ProcessPayment(amount); // This is where the client uses the adapter
        }
    }
}