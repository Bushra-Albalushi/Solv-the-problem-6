using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problam1
{
    internal class Class1
    {
        public static double Calculate(int a, int b, string op = "+")

        {

            switch (op)
            {
                case "+":
                return a + b;

                case "-":
                return a - b;

                case "*":
                return a * b;

                case "/":
                if (b == 0)

                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                        return double.NaN;

                    }

                    return (double)a / b;

                default:
                Console.WriteLine("Invalid operator. Defaulting to addition.");

                    return a + b;

            }
        }
    }
}

