using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common;
using TaskManagement.Contants;

namespace TaskManagement.Services
{
    public class LanguageService
    {
        public static string CurrentLanguage { get; set; }

        public void Handle()
        {
            switch (CurrentLanguage)
            {
                case "Az":
                    RegisterCommand registerCommand = new RegisterCommand();
                    registerCommand.Handle();
                    break;
                case "/login":
                    LoginCommand loginCommand = new LoginCommand();
                    loginCommand.Handle();
                    break;
                case "/update-language-preference":
                    LanguageUpdateCommand languageUpdateCommand = new LanguageUpdateCommand();
                    languageUpdateCommand.Handle();
                    break;
                case "/exit":
                    Console.WriteLine("Bye-bye");
                    return;
                default:
                    Console.WriteLine("Invalid command, pls try again");
                    break;
            }
        }
    }
}
