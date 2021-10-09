using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Task5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");

            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n,n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                int j = 0;
                Console.WriteLine();
                for (j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(0, 2);
                    Console.Write("{0} ", array[i,j]);
                }
            }
            Console.ReadKey();
        }
    }
}
