using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            const int n = 15;
            int[] array = new int[n];
            Random random = new Random();
            int sum = 0;
            int max = 0;
            int min = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0,50);
                Console.Write("{0} ",array[i]);
            }
            max = array[0];
            min = array[0];
            for (int j = 0; j < n; j++)
            {
                if (array[j]<=min)
                {
                    min = array[j];
                }
                if (array[j] >= max)
                {
                    max = array[j];
                }
            }
            sum = min + max;
            Console.WriteLine();
            Console.Write("Max = ");
            Console.WriteLine(max);
            Console.Write("Min = ");
            Console.WriteLine(min);
            Console.Write("Sum = ");
            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}
