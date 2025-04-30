using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    internal class Class1
    {
        public static void CountEvens(int[] numbers , ref int count)
        {
            int Count = 0;
            Console.WriteLine("\nEven numbers;");
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                   Console.WriteLine(number + " ");
                    count++;
                }
            }
            Console.WriteLine();
        }
    }
}
