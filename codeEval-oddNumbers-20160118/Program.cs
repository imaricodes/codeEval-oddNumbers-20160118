using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Print the odd numbers from 1 to 99, one number per line. CodeEval easy level challenge.
//Solved

namespace codeEval_oddNumbers_20160118
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i <=100; i++)
            {
            bool odd = (!(i % 2 == 0));

            if (odd)
            {
                Console.WriteLine(i);
            }

            }

            Console.ReadKey();
        

        }
    }
}
