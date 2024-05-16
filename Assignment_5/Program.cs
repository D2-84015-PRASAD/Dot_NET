using System.Drawing;

namespace Que5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] arr =null;
            Console.WriteLine("Enter size");
            int size=Convert.ToInt32(Console.ReadLine());
            CreateArray(arr, size);
        }

        static void CreateArray(Student[] arr,int size)
        {
            arr=new Student[size];
            acceptInfo(arr,size);
            printInfo(arr,size);
            Console.WriteLine("-----------------------------------------------------------------");
            printReverseInfo(arr,size);
            

        }

        static void acceptInfo(Student[]arr,int size)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].accept();
            }
        }

        static void printInfo(Student[] arr, int size)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].display();
            }
        }

        static void printReverseInfo(Student[] arr, int size)
        {
            for (int i = size-1; i >= 0; i--)
            {
                arr[i].display();
            }
        }
    }
}
