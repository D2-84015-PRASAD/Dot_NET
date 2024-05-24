using System.Runtime.CompilerServices;

namespace ASS_3_Q2
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
    public class Person:Date
    {
        private string name;
        private bool gender;
        private string address;
        Date birth;

        public Person()
        {

        }

        public Person(string name, bool gender, string address, Date birth)
        {
            this.name = name;
            this.gender = gender;
            this.address = address; 
            this.birth = birth;

        }

     

        public Date MyDate
        {
            get { return MyDate; }
            set { MyDate = value; }
        }

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

        public  void AcceptData()
        {
            Console.WriteLine("Enter Name : ");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter Gender : ");
            this.gender=Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Enter Address : ");
            this.address = Console.ReadLine();
            Console.WriteLine("Enter Birth date : ");
            base.AcceptDate();
        }

        public void DisplayData()
        {
            Console.WriteLine("Name : " + this.name);
            if (this.gender)
            {
                Console.WriteLine("Gender : Male");
            }
            else
            {
                Console.WriteLine("Gender : Female");
            }
            Console.WriteLine("Address : " + this.address);
            base.PrintDate();
        }

        public String ToStrings()
        {
            string st,dt;
            if (this.gender)
            {
                st="Gender : Male";
            }
            else
            {
                st="Gender : Female";
            }
            dt=base.ToString();
            return ("Name : "+this.name+" "+st+" Address : "+this.address+" Birth Date : "+dt);
        }




    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Person person = new Person();
            person.AcceptData();
            person.DisplayData();
            Console.WriteLine(person.ToStrings());
            Console.ReadLine();

        }
    }
}
