using Question_8;

namespace Question_10
{
    public class SuperVisor:Employee
    {
        private int subbordinates;

        public int MySubbordination
        {
            get { return subbordinates; }
            set { subbordinates = value; }
        }

        public SuperVisor() { 
        this.subbordinates = 0;
        }

        public SuperVisor(int subbordinates)
        {
            this.subbordinates = subbordinates;
        }

        public void Accept()
        {
            base.Accept();
            base.MyDestination = "Supervisor";
            Console.WriteLine("Enter Subbordinates : ");
            this.subbordinates=Convert.ToInt32(Console.ReadLine());

        }

        public void Display()
        {
            base.Print();
            Console.WriteLine("Subbordinates : " + this.subbordinates);
        }

        public string ToString()
        {
            string st=base.ToString();
            return "\n" + st + " Subbordinates : " + this.subbordinates;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SuperVisor superVisor = new SuperVisor();
            superVisor.Accept();
            superVisor.Display();
            superVisor.ToString();
        }
    }
}
