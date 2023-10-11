using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Employee
    {
        private string lastName;
        private string firstName;

        public Employee(string lastName, string firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        public void CalculateSalary(string position, int experience)
        {
            double baseSalary = 0;
            switch (position.ToLower())
            {
                case "manager":
                    baseSalary = 50000;
                    break;
                case "developer":
                    baseSalary = 60000;
                    break;
                case "designer":
                    baseSalary = 45000;
                    break;
                default:
                    Console.WriteLine("Недійсна посада");
                    return;
            }

            double taxRate = 0.15; 
            double salary = baseSalary + (experience * 1000); 

            double tax = salary * taxRate;
            double netSalary = salary - tax;

            Console.WriteLine("Інформація про співробітника:");
            Console.WriteLine("Прізвище: " + lastName);
            Console.WriteLine("Ім'я: " + firstName);
            Console.WriteLine("Посада: " + position);
            Console.WriteLine("Оклад: " + salary);
            Console.WriteLine("Податковий збір: " + tax);
            Console.WriteLine("Чистий оклад: " + netSalary);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введіть прізвище співробітника:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Введіть ім'я співробітника:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Введіть посаду співробітника (manager/developer/designer):");
            string position = Console.ReadLine();

            Console.WriteLine("Введіть стаж співробітника (у роках):");
            int experience = Convert.ToInt32(Console.ReadLine());

            Employee employee = new Employee(lastName, firstName);
            employee.CalculateSalary(position, experience);
        }
    }
}
