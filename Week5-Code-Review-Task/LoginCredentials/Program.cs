using System;

namespace LoginCredentials
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Login Form
             * login: user
             * password: user1234
             * Create a program that asks user's login credentials
             * Check if the user entered correct login and password
             * If the login and password are correct display 'Welcome'
             * If the login or password are incorrect dispay 'try again'
             
             */


            Console.WriteLine("Login:");
            string Login = Console.ReadLine();
            Console.WriteLine("Password:");
            string Password = Console.ReadLine();

            if ((Login != "user") && (Password != "user1234"))
            {
                Console.WriteLine("Welcome.");
            }
            else
            {
                Console.WriteLine("try again");
            }
            
        }
    }
}
