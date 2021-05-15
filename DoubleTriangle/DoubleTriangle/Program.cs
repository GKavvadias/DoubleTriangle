using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, number;
            Console.Write("Enter number of rows: ");
            number = int.Parse(Console.ReadLine());
           
            //NOTICE: REVERSE TRIANGLE
            for (i = 1; i <= number; i++)
            {
                for (j = 1; j <= number - i + 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

            //NOTICE: REGULAR TRIANGLE
            for (i = 1; i <= number; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine("");
            }
            Console.ReadKey();
        }    
    }  
}
        