using System;
using System.Collections.Generic;
using System.Text;

namespace TaskHero.Models
{
    internal class Parent : Account
    {
        private string _password;

        public Parent(string login , string password )
        
        {
            _login = login;
            _password = password;
            
        }
        
        public bool CheckPassword(string password)
        {
            return _password == password;
        }
        
    }
}
