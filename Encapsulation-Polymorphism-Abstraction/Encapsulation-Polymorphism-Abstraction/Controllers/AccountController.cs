﻿
using Encapsulation_Polymorphism_Abstraction.Helpers.Constants;
using Encapsulation_Polymorphism_Abstraction.Services;

namespace Encapsulation_Polymorphism_Abstraction.Controllers
{
    internal class AccountController
    {
        private readonly AccountService _accountService;

        public AccountController()
        {
            _accountService = new AccountService();
        }

        public void Login()
        {
            Console.WriteLine("Add your email:");
        Email: string email = Console.ReadLine();

            if (!email.Contains("@"))
            {
                Console.WriteLine(ResponseMessages.IncorrectEmailFormat);
                goto Email;
            }

            Console.WriteLine("Add your password:");
            string password = Console.ReadLine();

            var response = _accountService.Login(email, password);

            if (response)
            {
                Console.WriteLine(ResponseMessages.LoginSuccess);
            }
            else
            {
                Console.WriteLine(ResponseMessages.LoginFailed);
            }
        }
    }
}
