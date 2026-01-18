using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Strategy.Payment
{
    public class Checkout
    {
        private IPaymentStrategy _paymentStrategy; // Composition
        public Checkout(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }
        public void setStrategy(IPaymentStrategy paymentStrategy) // Setter for changing strategy at runtime
        {
            _paymentStrategy = paymentStrategy;
        }
        public void ProcessOrder(decimal amount)
        {
            _paymentStrategy.Pay(amount);
        }
    }
}
