using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Task4
    {
        static void Main(string[] args)
        {
            const int n = 20;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0,4} ", array[i]);
            }
            Console.WriteLine();
            for (int i = 1; i < n-1; i=i+2)
            {
                if ((array[i]>=0)&&(array[i]%2!=0))
                {
                    Console.Write("{0,4} ", array[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
