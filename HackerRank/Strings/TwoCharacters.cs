using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Implementation
{
    class TwoCharacters
    {
        public static void ProcessMain()
        {
            string s = Console.ReadLine();
            string result = ProcessTwoCharacters(s);

            Console.WriteLine(result.Length);
        }

        static string ProcessTwoCharacters(string s)
        {
            char[] chars = s.ToCharArray();

            string newString = "";

            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = i + 1; j < chars.Length; j++)
                {
                    string temp = RemoveChars(chars[i], chars[j], s);

                    if (temp.Length > newString.Length)
                    {
                        newString = temp;
                    }
                }
            }

            return newString;
        }

        public static string RemoveChars(char c1, char c2, string s)
        {
            char[] chars = s.ToCharArray();

            string newString = "";

            char lastChar = ' ';

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == c1 || chars[i] == c2)
                {
                    if (chars[i] == lastChar)
                    {
                        return "";
                    }

                    newString += chars[i];
                    lastChar = chars[i];

                }
            }

            return newString;
        }
    }
}
