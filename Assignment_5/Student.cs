/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que5
{
    internal class Student
    {
    }
}
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que5
{
    internal struct Student
    {
        string name;
        bool gender;
        int age;
        int std;
        char div;
        double marks;

        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.div = div;
            this.marks = marks;
        }

        public string Name { get => name; set => name = value; }
        public bool Gender { get => gender; set => gender = value; }
        public int Age { get => age; set => age = value; }
        public int Std { get => std; set => std = value; }
        public char Div { get => div; set => div = value; }
        public double Marks { get => marks; set => marks = value; }


        public void accept()
        {
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Gender true:male   false:female");
            gender = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Enter Age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Std");
            std = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Div");
            div = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter Marks");
            marks = Convert.ToDouble(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine(name);
            if (gender == true)
            {
                Console.WriteLine("male");
            }
            else
            {
                Console.WriteLine("female");
            }


            Console.WriteLine(age);
            Console.WriteLine(std);
            Console.WriteLine(div);
            Console.WriteLine(marks);
        }


    }


}
