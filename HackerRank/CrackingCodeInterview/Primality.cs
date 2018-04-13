using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.CrackingCodeInterview
{
    class Primality
    {
        static void Run()
        {
            int p = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < p; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                var res = IsPrime(n) ? "Prime" : "Not prime";
                Console.WriteLine($"{res}");
            }
        }

        static bool IsPrime(int number)
        {
            if (number > 1)
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                        return false;
                }

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
