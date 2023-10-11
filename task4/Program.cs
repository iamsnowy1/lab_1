using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class User
    {
        private string login;
        private string firstName;
        private string lastName;
        private int age;
        private readonly DateTime registrationDate;

        public User(string login, string firstName, string lastName, int age)
        {
            this.login = login;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.registrationDate = DateTime.Now;
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public DateTime RegistrationDate
        {
            get { return registrationDate; }
        }

        public void PrintUserInfo()
        {
            Console.WriteLine("Логін: " + login);
            Console.WriteLine("Ім'я: " + firstName);
            Console.WriteLine("Прізвище: " + lastName);
            Console.WriteLine("Вік: " + age);
            Console.WriteLine("Дата заповнення анкети: " + registrationDate.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Будь ласка, введіть інформацію про користувача:");
            Console.Write("Логін: ");
            string login = Console.ReadLine();
            Console.Write("Ім'я: ");
            string firstName = Console.ReadLine();
            Console.Write("Прізвище: ");
            string lastName = Console.ReadLine();
            Console.Write("Вік: ");
            int age = int.Parse(Console.ReadLine());

            User user = new User(login, firstName, lastName, age);

            Console.WriteLine("\nІнформація про користувача:");
            user.PrintUserInfo();
        }
    }
}
