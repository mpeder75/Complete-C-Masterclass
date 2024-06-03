
namespace Section_9___Updated___Polymorfi___Interfaces
{
    internal class PaypalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing paypal payment of: {amount}");
        }
    }
}
