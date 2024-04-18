using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    internal class PaymentSystem
    {
        IPayStrategy strategy;

        public PaymentSystem(IPayStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void MakePayment(double amount)
        {
            strategy.ProcessPayment(amount);
        }
    }
}
