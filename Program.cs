using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_2__Classes_and_Object__Class_Diagram_.Additional_Task;
using Lesson_2__Classes_and_Object__Class_Diagram_.Task_2;
using Lesson_2__Classes_and_Object__Class_Diagram_.Task_3;
using Lesson_2__Classes_and_Object__Class_Diagram_.Task_4;


namespace Lesson_2__Classes_and_Object__Class_Diagram_
{
    class Program
    {
        static void Main(string[] args)
        {

            // Additional Task

            //var user = new User(20, "max", "Maxim", "Sokol", new DateTime(2001, 11, 17));
            //user.ShowInfo();

            // Task 2

            //var converter = new Converter(36.7, 38.9, 112.9);
            //converter.UAHToAbroadCurrency();

            // Task 3

            // var employee = new Employee("Maxim", "Sokol");
            // employee.Tax = 8.7;

            //double salary = employee.CountSalary();
            // Console.WriteLine("Salary =\t" + salary);

            // Task 4

            var invoice = new Invoice(2288, "Maxim", "ASUS");

            double withNDS = invoice.CalculateTheSumWithNDS();
            double withoutNDS = invoice.CalculateTheSumWithoutNDS();

            invoice.ShowDate();
            Console.WriteLine("Price with NDS:\t" + withNDS);
            Console.WriteLine("Price without NDS:\t" + withoutNDS);

        }
    }
}
