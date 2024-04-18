using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    public class SignupViewFactory
    {
        public ISignupView CreateSignupView(string firstName, string lastName, string username, string email, string password, int phone, string address, string role, int roleId)
        {
            // Currently, only one type of signup view is implemented (CustomerSignupView).
            return new CustomerSignupView(firstName, lastName, username, email, password, phone, address, role, roleId);
        }
    }
}
