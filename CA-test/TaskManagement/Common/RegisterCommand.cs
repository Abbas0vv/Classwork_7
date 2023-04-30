using TaskManagement.Common.Validators;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;
using TaskManagement.Utilities;


namespace TaskManagement.Common
{
    public class RegisterCommand : ICommandHandler
    {
        public void Handle()
        {
            UserRepository userRepository = new UserRepository();
            ClassicUserValidator userValidator = new ClassicUserValidator();

            Console.WriteLine();
            string firstName = userValidator.GetAndValidateFirstName();
            Console.WriteLine();
            string lastName = userValidator.GetAndValidateLastName();
            Console.WriteLine();
            string email = userValidator.GetAndValidateEmail();
            Console.WriteLine();
            string password = userValidator.GetAndValidatePassword();

            User human = new User(firstName, lastName, password, email);
            userRepository.Insert(human);
        }
    }
}
