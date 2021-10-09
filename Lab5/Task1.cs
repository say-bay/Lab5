using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Task1
    {
        static void Main(string[] args)
        {
            const int n = 7;
            int sum = 0;
            decimal av = 0;
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
             array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j < n; j++)
            {
                sum = sum + array[j];
            }
            av = sum / n;
            Console.Write("Среднее ");
            Console.WriteLine(av);
            Console.ReadKey();
        }
    }
}
