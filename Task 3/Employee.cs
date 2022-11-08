using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2__Classes_and_Object__Class_Diagram_.Task_3
{
    class Employee
    {
        readonly string sName;
        readonly string fName;
        //----------------------------

        double tax;
        int experience;
        string position;
        //----------------------------

        public string Position
        {
            get { return position; }
        }
        //------------------------------------------------

        public string FirstName
        {
            get { return fName; }
        }
        //------------------------------------------------

        public string SecondName
        {
            get { return sName; }
        }
        //------------------------------------------------

        public int Experience
        {
            get { return experience; }
        }
        //------------------------------------------------

        public double Tax
        {
            set { this.tax = value; }
            get { return this.tax; }
        }
        //------------------------------------------------

        public Employee(string fName, string sName)
        {
            this.fName = fName;
            this.sName = sName;
        }
        //------------------------------------------------

        public void ShowDate()
        {
            Console.WriteLine($"Position:\t{this.Position}");
            Console.WriteLine($"Second Name:\t{this.SecondName}");
            Console.WriteLine($"First Name:\t{this.FirstName}");
            Console.WriteLine($"Experience:\t{this.Experience}");
            Console.WriteLine($"Tax:\t{this.Tax}");
        }
        //------------------------------------------------------------------------

        public double CountSalary()
        {
            double salary = default(double);

            Console.WriteLine("Positions in the company:");
            Console.WriteLine("1. Director");
            Console.WriteLine("2. Manager");
            Console.WriteLine("3. Beginner");

            Console.Write("Enter your position ->\t");
            string pos = Console.ReadLine();

            Console.Write("Enter your experience ->\t");
            int exp = int.Parse(Console.ReadLine());

            if(pos == "director" && exp == 15)
            {
                this.position = pos;
                this.experience = exp;

                salary = (experience * 500) - this.tax;
                ShowDate();
                return salary;
            }
           else if(pos == "manager" && exp == 10)
            {
                this.position = pos;
                this.experience = exp;

                salary = (experience * 250) - this.tax;
                ShowDate();
                return salary;
            }
            else if(pos == "beginner" && exp == 5)
            {
                this.position = pos;
                this.experience = exp;

                salary = (experience * 125) - this.tax;
                ShowDate();
                return salary;
            }
            else
            {
                return -1;
            }
        }
        //------------------------------------------------------------------------
    }
}
