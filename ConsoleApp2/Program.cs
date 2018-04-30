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
            int[] x= {20 ,6 ,7 ,8 ,9,10 };
            int y=5;
            int i, j, temp;

            for (i = y ; i > 1; i--)
                for (j = 1; j < i; j++)
                {
                           if (x[j] > x[j + 1])
                            {
                    temp = x[j];
                    x[j] = x[j + 1];
                    x[j + 1] = temp;
                            }
                }
            Console.WriteLine(x[0]);
            Console.WriteLine(x[1]);
            Console.WriteLine(x[2]);
            Console.WriteLine(x[3]);
            Console.WriteLine(x[4]);
            Console.WriteLine(x[5]);
            Console.ReadKey();
        }
    }
}
