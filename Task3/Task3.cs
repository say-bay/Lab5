using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Task3
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0,4} ", array[i]);
            }
            int a = 0;
            int b = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = i+1; j < 5; j++)
                {
                    if (array[i] > array[j])
                    {
                        a = array[i];
                        array[i] = array[j];
                        array[j] = a;
                    }
                }
            }
            for (int i = 5; i < n-1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] < array[j])
                    {
                        b = array[i];
                        array[i] = array[j];
                        array[j] = b;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0,4} ", array[i]);
            }
            Console.ReadKey();
        }
    }
}
