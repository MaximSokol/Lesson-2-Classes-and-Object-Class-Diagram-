using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2__Classes_and_Object__Class_Diagram_.Task_4
{
    class Invoice
    {
        public readonly int account;
        public readonly string customer;
        public readonly string provider;
        //--------------------------------

        string article;
        int quantity;
        //--------------------------------

        public string Article
        {
            set { this.article = value; }
            get { return this.article; }
        }
        //--------------------------------

        public int Quantity
        {
            set { this.quantity = value; }
            get { return this.quantity; }
        }
        //--------------------------------

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        //-----------------------------------------------------------------

        public void ShowDate()
        {
            Console.WriteLine($"Account:\t{account}");
            Console.WriteLine($"Customer:\t{customer}");
            Console.WriteLine($"Provider:\t{provider}");
            Console.WriteLine($"Article:\t{this.Article}");
            Console.WriteLine($"Quantity:\t{this.Quantity}");
        }
        //-----------------------------------------------------------------

        public double CalculateTheSumWithNDS()
        {
            double sum = default(double);

            Console.Write("Enter article ->\t");
            string art = Console.ReadLine();

            Console.Write("Enter quantity ->");
            int quant = int.Parse(Console.ReadLine());

            if (art == "laptop" && quant == 5)
            {
                this.Article = art;
                this.Quantity = quant;
                sum = (this.Quantity * 8750) + 700;
                
                return sum;
            }
            else if (art == "smart" && quant == 5)
            {
                this.Article = art;
                this.Quantity = quant;
                sum = (this.Quantity * 5400) + 1200;

                return sum;
            }
            else if(art == "clock" && quant == 5)
            {
                this.Article = art;
                this.Quantity = quant;
                sum = (this.Quantity * 3860) + 2400;

                return sum;
            }
            else
            {
                return -1;
            }
        }
        //-----------------------------------------------------------------

        public double CalculateTheSumWithoutNDS()
        {
            double sum = default(double);

            Console.Write("Enter article ->\t");
            string art = Console.ReadLine();

            Console.Write("Enter quantity ->");
            int quant = int.Parse(Console.ReadLine());

            if (art == "laptop" && quant == 5)
            {
                this.Article = art;
                this.Quantity = quant;
                sum = (this.Quantity * 8750);

                return sum;
            }
            else if (art == "smart" && quant == 5)
            {
                this.Article = art;
                this.Quantity = quant;
                sum = (this.Quantity * 5400);

                return sum;
            }
            else if (art == "clock" && quant == 5)
            {
                this.Article = art;
                this.Quantity = quant;
                sum = (this.Quantity * 3860);

                return sum;
            }
            else
            {
                return -1;
            }
        }
        //-----------------------------------------------------------------
    }
}
