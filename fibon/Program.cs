using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibon
{
    internal class Program
    {
        static int Fibonacci(int n)
        {
            int n1 = 0;
            int n2 = 1;
            int sum;

            for (int i = 2; i < n; i++)
            {
                sum = n1 + n2;
                n1 = n2;
                n2 = sum;
            }

            return n == 0 ? n1 : n2;
        }
        static void Main(string[] args)
        {
            int result = Fibonacci(5);
            Console.WriteLine(result);
            result = Fibonacci(10);
            Console.WriteLine(result);
            result = Fibonacci(15);
            Console.WriteLine(result);
            result = Fibonacci(20);
            Console.WriteLine(result);
            result = Fibonacci(25);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
