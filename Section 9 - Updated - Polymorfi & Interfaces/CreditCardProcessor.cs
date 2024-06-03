
namespace Section_9___Updated___Polymorfi___Interfaces
{
    internal class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Preocessing credit card payment of: {amount}");
        }
    }
}
