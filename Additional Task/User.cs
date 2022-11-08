using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2__Classes_and_Object__Class_Diagram_.Additional_Task
{
    class User
    {
        int grade;
        string login;
        string firstName;
        string secondName;
        readonly DateTime dateOfFillingIn;
        //----------------------------------------------------------

        public User(int grade, string login, string fName, 
            string sName, DateTime fillingIn)
        {
            this.grade = grade;
            this.login = login;
            this.firstName = fName;
            this.secondName = sName;
            this.dateOfFillingIn = fillingIn;
        }
        //----------------------------------------------------------

        public void ShowInfo()
        {
            Console.WriteLine("--==[Date of the person]==--");
            Console.WriteLine($"Grade:\t{this.grade}");
            Console.WriteLine($"Login:\t{this.login}");
            Console.WriteLine($"First Name:\t{this.firstName}");
            Console.WriteLine($"Second Name:\t{this.secondName}");
            Console.WriteLine($"Date of filling the questionnaire:\t{this.dateOfFillingIn}");
        }
        //----------------------------------------------------------
    }
}
