using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Strings
{
    class PalindromeIndex
    {
        //https://www.hackerrank.com/challenges/palindrome-index/problem

        static int palindromeIndex(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                int r = s.Length - i - 1;

                if (i <= r)
                {
                    if (s[i] != s[r])
                    {
                        var iTemp = s.Remove(i, 1);

                        if (IsPalindrome(iTemp.ToString()))
                        {
                            return i;
                        }

                        var rTemp = s.Remove(r, 1);

                        if (IsPalindrome(rTemp.ToString()))
                        {
                            return r;
                        }
                    }
                }
            }



            return -1;
        }

        static bool IsPalindrome(string s)
        {

            for (int i = 0; i < s.Length; i++)
            {
                int r = s.Length - i - 1;

                if (i <= r)
                {
                    if (s[i] != s[r])
                    {
                        return false;
                    }
                }
                else
                {
                    break;
                }
            }

            return true;

        }

        public static bool IsPalindrome2(string str)
        {
            return str.SequenceEqual(str.Reverse());
        }

        public static void ProcessMain()
        {
            using (System.IO.StreamReader arquivo = new System.IO.StreamReader(@"F:\Projetos\Visual Studio 2017\HackerRank\HackerRank\Strings\Iinput.txt"))
            {

                string line = arquivo.ReadLine();

                while (line != null)
                {
                    int result = palindromeIndex(line);
                    Console.WriteLine(result);
                }
            }


            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                string s = Console.ReadLine();
                int result = palindromeIndex(s);
                Console.WriteLine(result);
            }
        }
    }
}
