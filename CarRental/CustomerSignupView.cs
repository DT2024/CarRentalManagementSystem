using ProjectCarRentalSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    public class CustomerSignupView : ISignupView
    {
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly string _username;
        private readonly string _email;
        private readonly string _password;
        private readonly int _phone;
        private readonly string _address;
        private readonly string _role;
        private readonly int _roleId;

        public CustomerSignupView(string firstName, string lastName, string username, string email, string password, int phone, string address, string role, int roleId)
        {
            _firstName = firstName;
            _lastName = lastName;
            _username = username;
            _email = email;
            _password = password;
            _phone = phone;
            _address = address;
            _role = role;
            _roleId = roleId;
        }

        public bool RegisterUser()
        {
            // Instantiate DatabaseSystem and register the user
            DatabaseSystem databLogin = new DatabaseSystem();
            return databLogin.RegisterUser(_firstName, _lastName, _username, _email, _password, _phone, _address, _role, _roleId);
        }
    }
}
