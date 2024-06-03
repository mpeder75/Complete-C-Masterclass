using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_9___Updated___Polymorfi___Interfaces
{
    internal class PaymentService
    {
        private readonly IPaymentProcessor _processor;   // Field er interface

        public PaymentService(IPaymentProcessor payment)
        {
            this._processor = payment;
        }

        public void ProcessOrderPayment(decimal amount)
        {
            // Polymorfi: Interface IPaymentProcessor metoden ProcessPayment kaldes med amount som arg
            _processor.ProcessPayment(amount); 
        }
    }
}
