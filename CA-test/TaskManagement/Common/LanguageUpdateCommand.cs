using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Services;

namespace TaskManagement.Common
{
    public class LanguageUpdateCommand : ICommandHandler
    {
        public void Handle()
        {
            Console.WriteLine("Which language do you wand : ");
            Console.WriteLine("/aze, /eng, /rus");

            string command = Console.ReadLine()!;
            SendLanguageCode(command);
        }

        public void SendLanguageCode(string command)
        {
            if (command is null)
                return;

            if (command == "/aze" || command == "/eng" || command == "/rus")
            {
                LanguageService.CurrentLanguage = command;
            }
        }
    }
}
