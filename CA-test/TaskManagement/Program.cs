using Microsoft.VisualBasic;
using TaskManagement.Common;
using TaskManagement.Database;
using TaskManagement.Services;

namespace TaskManagement
{
    //Encapsulaiton

    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string command = Console.ReadLine()!;

                switch (command)
                {
                    case "/register":
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
}
