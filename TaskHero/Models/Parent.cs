using System;
using System.Collections.Generic;
using System.Text;

namespace TaskHero.Models
{
    internal class Parent : Account
    {
        private string _password;

        public Parent(string login , string password , AccessType accessType)
        
        {
            _login = login;
            _password = password;
            _accessType = accessType;
        }
        
        public bool CheckPassword(string password)
        {
            return _password == password;
        }
        
    }
}
