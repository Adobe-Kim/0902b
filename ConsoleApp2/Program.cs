using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 5;
            int c = 0;

            PrintXY(x, y);

            Swap(x, y);                       // call by value
            PrintXY(x, y);


            c = Swap(ref x, ref y);               // call by reference
            PrintXY(x, y);
        }

        static void Swap(int a, int b)
        {
            int c = 0;

            c = a;
            a = b;
            b = c;
        }

        static int Swap(ref int a, ref int b)
        {
            int c = 0;

            c = a;
            a = b;
            b = c;

            Console.WriteLine("It's work");
            return a + b;
        }

        static void PrintXY(int a, int b)
        {
            Console.Write("x=");
            Console.WriteLine(a);
            Console.Write("y=");
            Console.WriteLine(b);
            Console.WriteLine();
        }


    }
}
