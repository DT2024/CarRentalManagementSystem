using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCarRentalSystem
{
    public interface ICustomerBuilder
    {
        ICustomerBuilder SetUserID(int userId);
        ICustomerBuilder SetUserName(string userName);
        ICustomerBuilder SetPassword(string password);
        ICustomerBuilder SetRole(string role);
        ICustomerBuilder SetFirstName(string firstName);
        ICustomerBuilder SetLastName(string lastName);
        ICustomerBuilder SetEmail(string email);
        ICustomerBuilder SetPhoneNumber(int phoneNumber);
        ICustomerBuilder SetAddress(string address);
        ICustomerBuilder SetRoleID(int roleId);
        Customer Build();
    }
}
