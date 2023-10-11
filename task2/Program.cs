using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Converter
    {
        private double usdRate;
        private double eurRate;
        private double plnRate;

       
        public Converter(double usd, double eur, double pln)
        {
            usdRate = usd;
            eurRate = eur;
            plnRate = pln;
        }

        
        public double ConvertFromUah(double amount, string currency)
        {
            switch (currency.ToLower())
            {
                case "usd":
                    return amount / usdRate;
                case "eur":
                    return amount / eurRate;
                case "pln":
                    return amount / plnRate;
                default:
                    throw new ArgumentException("Невідома валюта");
            }
        }

       
        public double ConvertToUah(double amount, string currency)
        {
            switch (currency.ToLower())
            {
                case "usd":
                    return amount * usdRate;
                case "eur":
                    return amount * eurRate;
                case "pln":
                    return amount * plnRate;
                default:
                    throw new ArgumentException("Невідома валюта");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            Converter converter = new Converter(28.0, 33.0, 7.5);

            Console.WriteLine("Оберіть операцію:");
            Console.WriteLine("1 - Конвертація з гривні в іншу валюту");
            Console.WriteLine("2 - Конвертація з іншої валюти в гривню");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Введіть суму в гривнях:");
                double amount = double.Parse(Console.ReadLine());
                Console.WriteLine("Введіть валюту (usd, eur, pln):");
                string currency = Console.ReadLine();
                double result = converter.ConvertFromUah(amount, currency);
                Console.WriteLine($"Результат: {result} {currency}");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Введіть суму в іншій валюті:");
                double amount = double.Parse(Console.ReadLine());
                Console.WriteLine("Введіть валюту (usd, eur, pln):");
                string currency = Console.ReadLine();
                double result = converter.ConvertToUah(amount, currency);
                Console.WriteLine($"Результат: {result} UAH");
            }
            else
            {
                Console.WriteLine("Невірний вибір операції.");
            }
        }
    }
}
