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
            string s = "aa";
            string result = ProcessSuperReducedString(s);
            Console.WriteLine(result);
        }

        static string ProcessSuperReducedString(string s)
        {
            var chars = s.ToCharArray();

            bool continueRemoving = false;
            string newString = chars[0].ToString();
            //abcdeefgijkl

            do
            {
                if (chars.Length > 0)
                {
                    char c = chars[0];

                    continueRemoving = false;
                    newString = chars[0].ToString();
                    for (int i = 1; i < chars.Length; i++)
                    {
                        if (c == chars[i] && !continueRemoving)
                        {
                            continueRemoving = true;
                            newString = newString.Substring(0, newString.Length - 1);
                        }
                        else
                        {
                            c = chars[i];
                            newString += chars[i];
                        }
                    }

                    chars = newString.ToCharArray();
                }
                else
                {
                    continueRemoving = false;
                }

            } while (continueRemoving);

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
