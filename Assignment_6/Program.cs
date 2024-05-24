namespace ASS_3_Q1
{
    public class Date
    {
        private int day;
        private int month;
        private int year;

        public int MyYear
        {
            get { return year; }
            set { year = value; }
        }


        public int MyMonth
        {
            get { return month; }
            set { month = value; }
        }


        public int MyDay
        {
            get { return day; }
            set { day = value; }
        }

        public Date()
        {
            this.day = 0;
            this.month = 0;
            this.year = 0;
        }

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void AcceptDate()
        {
            Console.WriteLine("Enter Day : ");
            this.day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month : ");
            this.month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Year : ");
            this.year = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintDate()
        {
            Console.WriteLine("Day : " + this.day + " Month : " + this.month + " Year : " + this.year);
        }

        public bool IsValid()
        {
            if (this.day > 0 && this.day < 31 && this.month > 0 && this.month < 13 && this.year > 0 && this.year < 9999)
            {
                return true;
            }
            return false;
        }

        public string ToString()
        {
            return this.day + "/" + this.month + "/" + this.year;
        }
        public static Date operator -(Date dt1, Date dt2)
        {
            Date d3 = new Date();
            d3.day = dt1.day - dt2.day;
            d3.month = dt1.month - dt2.month;
            d3.year = dt1.year - dt2.year;

            return d3;
        }
        public static int YearDifference(Date dt1, Date dt2)
        {
            return dt1.year - dt2.year;
        }

    }

    public class Person
    {
        private string name;
        private bool gender;
        private string address;
        Date birth;

        public string MyAddress
        {
            get { return address; }
            set { address = value; }
        }


        public bool MyGender
        {
            get { return gender; }
            set { gender = value; }
        }


        public string MyName
        {
            get { return name; }
            set { name = value; }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
