using Question_8;

namespace Question_11
{
    public class WageEmp:Employee
    {
        private int hour;
        private int rate;

        public WageEmp()
        {

        }

        public WageEmp(int hour, int rate)
        {
            this.hour = hour;
            this.rate = rate;   
        }

        public int MyRate
        {
            get { return rate; }
            set { rate = value; }
        }


        public int MyHour
        {
            get { return hour; }
            set { hour = value; }
        }

        public void AcceptWageData()
        {
            base.Accept();
            base.MyDestination = "Wage";
            Console.WriteLine("Enter Hour : ");
            this.hour=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Rate : ");
            this.rate=Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayWageData()
        {
            base.Print();
            Console.WriteLine("Total Payment : " + (this.hour * this.rate));

        }

        public string GetWageName()
        {
            string str=base.ToString();
            return str+" Hour : "+this.hour+" Rate : "+this.rate+ " Total Payment : "+(this.hour*this.rate);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            WageEmp emp = new WageEmp();
            emp.AcceptWageData();
            emp.DisplayWageData();
        }
    }
}
