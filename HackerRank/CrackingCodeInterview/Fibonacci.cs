using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.CrackingCodeInterview
{
    class FibonacciClass
    {
        public static int Fibonacci(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            else
                return Fibonacci(n - 2) + Fibonacci(n - 1);
        }

        static void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonacci(n));
        }
    }
}
