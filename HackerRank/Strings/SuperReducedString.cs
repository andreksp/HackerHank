using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Strings
{
    class SuperReducedString
    {
        public static void ProcessMain()
        {
            //string s = Console.ReadLine();
            string s = "baab";
            string result = ProcessSuperReducedString(s);
            Console.WriteLine(result);
        }

        static string ProcessSuperReducedString(string s)
        {
            char[] chars = s.ToCharArray();

            string newString = "";
            //abcdeefgijkl

            for (int i = 0; i < chars.Length - 1; i++)
            {
                if (chars[i] == chars[i + 1])
                {
                    string firstPart = i > 0 ? new string(chars.Take(i).ToArray()) : "";
                    string secondPart = newString.Length - 2 < chars.Length ? new string(chars.Skip(i + 2).ToArray()) : "";

                    newString = firstPart + secondPart;

                    chars = newString.ToCharArray();
                    i = -1;
                }
            }

            if (string.IsNullOrEmpty(newString))
            {
                return "Empty String";
            }
            else
            {
                return newString;
            }
        }
    }
}
