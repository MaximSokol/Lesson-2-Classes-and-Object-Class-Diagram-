using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2__Classes_and_Object__Class_Diagram_.Task_2
{
    class Converter
    {
        double UAH = default(double);
        //-------------------------

        readonly double USD;
        readonly double EUR;
        readonly double RUB;
        //-------------------------

        public Converter(double usd, double eur, double rub)
        {
            this.USD = usd;
            this.EUR = eur;
            this.RUB = rub;
        }
        //--------------------------------------------------------------

        public void UAHToAbroadCurrency()
        {
            Console.Write("Enter the sum of UAH ->\t");
            double enteredSum = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose the operation:");
            Console.WriteLine("1. UAH to USD");
            Console.WriteLine("2. UAH to EUR");
            Console.WriteLine("3. UAH to RUB");

            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine($"UAH to USD = {Math.Round((enteredSum / this.USD), 2)}");
                    break;
                case 2:
                    Console.WriteLine($"UAH to EUR = {Math.Round((enteredSum / this.EUR), 2)}");
                    break;
                case 3:
                    Console.WriteLine($"UAH to EUR = {Math.Round((enteredSum / this.RUB), 2)}");
                    break;
                default:
                    Console.WriteLine("The operation is absent!");
                    break;
            }
        }
        //--------------------------------------------------------------

        public void AbroadCurrencyToUAH()
        {
            Console.Write("Enter the sum of abroad currency ->\t");
            double enteredSum = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose the operation:");
            Console.WriteLine("1. USD to UAH ");
            Console.WriteLine("2. EUR to UAH");
            Console.WriteLine("3. RUB to UAH");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"USD to UAH  = {Math.Round((enteredSum * this.USD), 2)}");
                    break;
                case 2:
                    Console.WriteLine($"EUR to UAH = {Math.Round((enteredSum * this.EUR), 2)}");
                    break;
                case 3:
                    Console.WriteLine($"RUB to UAH = {Math.Round((enteredSum * this.RUB), 2)}");
                    break;
                default:
                    Console.WriteLine("The operation is absent!");
                    break;
            }
        }
        //--------------------------------------------------------------
    }
}
