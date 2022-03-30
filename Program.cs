using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmonicNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i , n;
            double s = 0.0;               //double used for output (output is comes in decimal values)
            Console.Write("Enter the value: ");
            n = int.Parse(Console.ReadLine());            
            for (i = 1; i <= n; i++)
            {
                Console.Write("1/{0}+",i);   //placeholder syntax
                s += 1 / (float)i;            // += is used for incriment plus 1
            }
            Console.Write("\nSum of series upto {0} /terms: {1} \n ",n,s);
            Console.ReadLine();
        }
    }
}
