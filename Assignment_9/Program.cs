using Question_8;
using System.Data;

namespace Question_9
{
    public class Manager:Employee

    {
        private double bonus;

        public Manager()
        {
            base.MyDestination = "Manager";
            this.bonus = 0;
        }

        public Manager(double bonus)
        {
            this.bonus = bonus;
        }
        public double MyBonus
        {
            get { return bonus; }
            set { bonus = value; }
        }

        public void Accept()
        {
            base.Accept();
            base.MyDestination = "Manager";
            Console.WriteLine("Enter bonus : ");
            this.bonus=Convert.ToDouble(Console.ReadLine());
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine("Bonus : " + this.bonus);

        }

        public string ToString()
        {
            string st=base.ToString();
            return st+" Bonus : "+this.bonus;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.Accept();
            manager.Print();

           
        }
    }
}
