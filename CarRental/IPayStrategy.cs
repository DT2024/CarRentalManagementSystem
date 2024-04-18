using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    //For the payment , it has been decided to use Strategy Design pattern
    internal interface IPayStrategy
    {
        void ProcessPayment(double amount);
    }
}
