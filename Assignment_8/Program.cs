using ASS_3_Q2;
using System.Runtime.InteropServices;

namespace Question_8
{


    public class Employee : Person
    {
        static int id;
        private double salary;
        DepartmentType Dept;

        private string destination;

        public DepartmentType MyDept
        {
            get { return Dept; }
            set { Dept = value; }
        }

        public enum DepartmentType
        {
            RESEARCH = 1,
            MANAGEMENT=2,
            SALES=3
        }

        public string MyDestination
        {
            get { return destination; }
            set { destination = value; }
        }


        public double MySalary
        {
            get { return salary; }
            set { salary = value; }
        }


        public Employee() {
            id++;
            this.salary = 0;
            this.destination = " ";
            this.Dept = 0;
        }

        public Employee(string destination,double salary,DepartmentType Dept) {
            id++;
            this.salary = salary;
            this.destination = destination;
            this.Dept = Dept;
        }

        public void Accept()
        {
            base.AcceptData();
            Console.WriteLine("Enter salary : ");
            this.salary=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter designation : ");
            this.destination = Console.ReadLine();

            Console.WriteLine("Enter Department : (1.Reasearch, 2. Management, 3. Sales )");
            this.Dept= (DepartmentType)Convert.ToInt32(Console.ReadLine());

        }

        public void AcceptEmployee()
        {
            base.AcceptData();
            Console.WriteLine("Enter salary : ");
            this.salary=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Department : (1.Reasearch, 2. Management, 3. Sales )");
            this.Dept= (DepartmentType)Convert.ToInt32(Console.ReadLine());

        }
      
        public void Print()
        {
            base.DisplayData();
            Console.WriteLine("Salary : "+this.salary);
            Console.WriteLine("Designation : "+this.destination);
            if (Convert.ToInt32(this.Dept) == 1)
            {
                Console.WriteLine("Department : Reasearch");
            }
            else if (Convert.ToInt32(this.Dept) == 2)
            {
                Console.WriteLine("Department : Management");
            }
            else
            {
                    Console.WriteLine("Department : Sales");   
            }
        }

        
        public string ToString()
        {
            string dpt;
            string st=base.ToString();
            if (Convert.ToInt32(this.Dept) == 1)
            {
                dpt="Department : Reasearch";
            }
            else if (Convert.ToInt32(this.Dept) == 2)
            {
                dpt="Department : Management";
            }
            else
            {
                dpt="Department : Sales";
            }
            return st + " Salary is : " +this.salary+" Designation is : "+this.Dept + " Department : "+dpt;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Accept();
            emp.Print();
            emp.ToString();
        }
    }
}
