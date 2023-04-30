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
                case "/aze":
                    AzeLanguage //I CAN NOT 
                default:
                    Console.WriteLine("Invalid command, pls try again");
                    break;
            }
        }
    }
}
