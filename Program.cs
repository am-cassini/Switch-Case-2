// ITN114 Wireless Internet and Pervasive Computing
// Switch case C# exercise 2
// Azalea Mae C. Manimog

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;

            Console.WriteLine("Enter two numbers to find the maximum number: ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            switch (x > y)
            {
                case true:
                    Console.WriteLine("\n" + x + " is maximum");
                    break;

                case false:
                    Console.WriteLine("\n" + y + " is maximum");
                    break;
            }
            Console.ReadLine();
        }
    }
}
