using System;

namespace ConsoleApp1
{
    class Program
    {
        int iNum1 = 0, iNum2 = 0;

        void GetNumbers()
        {
            Console.WriteLine("enter 1 no=");
            while (!Int32.TryParse(Console.ReadLine(), out iNum1)) { Console.WriteLine("Enter no 1 again="); }
            Console.WriteLine("enter 2 no=");
            while (!Int32.TryParse(Console.ReadLine(), out iNum2)) { Console.WriteLine("Enter no 2 again="); }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.GetNumbers();
            Console.WriteLine("{0}\n{1}\n", p.iNum1, p.iNum2);
            //fergfeog
        }
    }
}
