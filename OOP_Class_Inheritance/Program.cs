using System;

namespace OOP_Class_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
        repeat:   
            Account account = new Account(Console.ReadLine(),Console.ReadLine());

           if (account.username == "Admin" && account.password == "AdminEA18yr@")
            {
                Console.WriteLine("giriş ugurludur");
            }
           else
            {
                Console.WriteLine("username ve ya password sehvdir");
                goto repeat;
            }




        }
    }
}
