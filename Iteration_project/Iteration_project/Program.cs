using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_project
{
    class Triangle
    {
       
        static void Main()
        {
            int a, b, spc, n, c;
            Console.Write("\n\n");     
            Console.Write("  Enter the number of rows that you would like in your asterisk triangle: ");
           
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\n");

            spc = n + 4 - 1;
           
                for (a = 1; a <= n; a++)
                {
                    for (c = spc; c >= 1; c--)
                    {
                        Console.Write(" ");
                    }

                    for (b = 1; b <= a; b++)
                        Console.Write("* ");
                    Console.Write("\n");
                    spc--;
                }
            Console.ReadKey();
        }
    }
}