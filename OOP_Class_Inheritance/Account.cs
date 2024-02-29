using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Class_Inheritance
{
    internal class Account
    {
        public string username;
        public string password;


        public Account(string Username, string Password)
        {
            username=Username; 
            password=Password;
        }

    }
}
