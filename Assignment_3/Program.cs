namespace Assignment1_Que3
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // int choice = Int32.Parse(args[0]);
           int num1 = Int32.Parse(args[0]);
           int num2 = Int32.Parse(args[1]);
            int choice;
          
            

            do
            {
                Console.WriteLine("0 : Add");
                Console.WriteLine("1 : Sub");
                Console.WriteLine("2 : Mul");
                Console.WriteLine("3 : Div");
                Console.WriteLine("4 : Exit");
                Console.WriteLine("Enter choice");
                String str = Console.ReadLine();
                choice = Convert.ToInt32(str);

                switch (choice)
                {
                    case 0:
                        int res1 = Program.add(num1, num2);
                        Console.WriteLine(res1);
                        break;

                    case 1:
                        int res2 = Program.sub(num1, num2);
                        Console.WriteLine(res2);
                        break;

                    case 2:
                        int res3 = Program.mul(num1, num2);
                        Console.WriteLine(res3);
                        break;

                    case 3:
                        int res4 = div(num1, num2);
                        Console.WriteLine(res4);
                        break;

                    case 4:
                        Console.WriteLine("Thank you!!");
                        break;

                    default:
                        break;


                }

            } while (choice != 4);


        }

      static  int add(int num1,int num2) {
        return (num1 + num2);   
        }

      static int sub(int num1,int num2)
        {
            return (num1 - num2);
        }

        static int mul(int num1,int num2)
        {
            return (num1 * num2);
        }

        static int div(int num1,int num2)
        {
            return (num1 / num2);
        }
    }

   
}
