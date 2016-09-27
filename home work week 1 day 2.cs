using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
           
        {
         for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0) Console.Write("fizz");
                if (i % 5 == 0) Console.Write("buzz");
                if (Console.CursorLeft == 0) Console.Write(i);


                Console.WriteLine();


            }

            Console.ReadLine();
        }
    }
}
