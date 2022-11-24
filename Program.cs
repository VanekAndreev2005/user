using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User()
            {
                FirstName = "Андреев",
                Name = "Иван",
                Login = "Admin",
                Password = "admin",
            };
            /*Console.WriteLine("Введите логин");
            string login = Console.ReadLine();
            user.AuthorizeUser(login, "");*/
            Console.WriteLine(user.Name);
            Console.WriteLine("Введите имя");
            user.Name = Console.ReadLine();
            Console.WriteLine($"Ваше новое имя - {user.Name}");
            Console.ReadLine();
        }
    }

    class User
    {
        public string FirstName;
        public string Name;

        public string Login;
        public string Password;

        public void AuthorizeUser(string login, string password)
        {
            if(login == Login)
            {
                Console.WriteLine("Вы успешно авторизовались");
            }
            else
            {
                Console.WriteLine("Авторизация не удалась");
            }
        }
    }
}
