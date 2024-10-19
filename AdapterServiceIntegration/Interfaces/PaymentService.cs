namespace AdapterServiceIntegration.Interfaces
{
    public class PaymentService
    {
        public virtual void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"[PaymentClient] Requesting payment of {amount} through IPaymentService.");
        }
    }
}