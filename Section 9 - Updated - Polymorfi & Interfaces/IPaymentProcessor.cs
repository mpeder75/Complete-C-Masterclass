using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_9___Updated___Polymorfi___Interfaces
{
    internal interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
}
