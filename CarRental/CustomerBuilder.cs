using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCarRentalSystem
{
    internal class CustomerBuilder : ICustomerBuilder
    {
        private int userId;
        private string userName;
        private string password;
        private string role;
        private string firstName;
        private string lastName;
        private string email;
        private int phoneNumber;
        private string address;
        private int roleId;

        public ICustomerBuilder SetUserID(int userId)
        {
            this.userId = userId;
            return this;
        }

        public ICustomerBuilder SetUserName(string userName)
        {
            this.userName = userName;
            return this;
        }

        public ICustomerBuilder SetPassword(string password)
        {
            this.password = password;
            return this;
        }

        public ICustomerBuilder SetRole(string role)
        {
            this.role = role;
            return this;
        }

        public ICustomerBuilder SetFirstName(string firstName)
        {
            this.firstName = firstName;
            return this;
        }

        public ICustomerBuilder SetLastName(string lastName)
        {
            this.lastName = lastName;
            return this;
        }

        public ICustomerBuilder SetEmail(string email)
        {
            this.email = email;
            return this;
        }

        public ICustomerBuilder SetPhoneNumber(int phoneNumber)
        {
            this.phoneNumber = phoneNumber;
            return this;
        }

        public ICustomerBuilder SetAddress(string address)
        {
            this.address = address;
            return this;
        }

        public ICustomerBuilder SetRoleID(int roleId)
        {
            this.roleId = roleId;
            return this;
        }

        public Customer Build()
        {
            return new Customer(userId, userName, password, role, firstName, lastName, email, phoneNumber, address, roleId);
        }
    }
}
