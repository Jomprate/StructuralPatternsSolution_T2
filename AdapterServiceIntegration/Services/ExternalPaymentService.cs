namespace AdapterServiceIntegration.Services
{
    public class ExternalPaymentService
    {
        public void MakePayment(string currency, decimal amount)
        {
            Console.WriteLine($"[ExternalPaymentService] Processing {amount} {currency} using ExternalPaymentService.");
        }
    }
}