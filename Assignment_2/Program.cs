namespace Assignment1_Que2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
          
            int choice;
            do
            {
                Console.WriteLine("0 : Exit!!!");
                Console.WriteLine("1 : Add");
                Console.WriteLine("2 : Sub");
                Console.WriteLine("3 : Multiply");
                Console.WriteLine("4 : Divide");
                Console.WriteLine("Enter choice");
                String s3 = Console.ReadLine();

                choice = Convert.ToInt32(s3);

                switch (choice)

                {
                    case 0:
                        Console.WriteLine("Thank you!!!!");
                        break;

                    case 1:
                        Console.WriteLine("Enter First No.");
                        String s1 = Console.ReadLine();
                        Console.WriteLine("Enter Second No.");
                        String s2 = Console.ReadLine();

                        int num1 = Convert.ToInt32(s1);
                        int num2 = Convert.ToInt32(s2);

                        int result = num1 + num2;
                        Console.WriteLine("Result" + result);
                        break;

                    case 2:

                        Console.WriteLine("Enter 1st No.");
                        String str1 = Console.ReadLine();
                        Console.WriteLine("Enter 2nd No.");
                        String str2 = Console.ReadLine();
                        int num3 = Convert.ToInt32(str1);
                        int num4 = Convert.ToInt32(str2);

                        int rs = num3 - num4;

                        Console.WriteLine(rs);

                        break;

                    case 3:
                        Console.WriteLine("Enter 1st No.");
                        String s4 = Console.ReadLine();
                        Console.WriteLine("Enter 2nd No.");
                        String s5 = Console.ReadLine();

                        int no1 = Convert.ToInt32(s4);
                        int no2 = Convert.ToInt32(s5);

                        int no3 = no1 * no2;

                        Console.WriteLine(no3);

                        break;

                    case 4:

                        Console.WriteLine("Enter 1st no.");
                        String st1 = Console.ReadLine();
                        Console.WriteLine("Enter 2nd no.");
                        String st2 = Console.ReadLine();

                        int no4 = Convert.ToInt32(st1);
                        int no5 = Convert.ToInt32(st2);
                        int no6 = no4 / no5;
                        Console.WriteLine(no6);
                        break;




                    default:
                        break;
                }

            } while (choice != 0);


        }
    }
}
