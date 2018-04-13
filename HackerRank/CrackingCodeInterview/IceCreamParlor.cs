using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
public class IceCreamParlor
{
    static void Solve(int[] arr, int money)
    {
        // Complete this function
        var ordered = arr.OrderBy(p => p).ToArray();

        for (int i = 0; i < arr.Length; i++)
        {
            int t = Math.Abs(arr[i] - money);

            if (Array.BinarySearch(ordered, t) > -1)
            {
                int newT = Array.IndexOf(arr, t, i + 1, arr.Length - i - 1);

                if (newT > -1)
                {
                    Console.WriteLine($"{i + 1} {newT + 1}");
                    break;
                }
            }
        }
    }

    public static void Run()
    {
        string txt = File.ReadAllText(@"F:\Projetos\Visual Studio 2017\HackerRank\HackerRank\CrackingCodeInterview\IceCreamParlor.txt");
        string[] stringSeparators = new string[] { "\r\n" };
        var a = new List<string>(txt.Split(stringSeparators, StringSplitOptions.None));

        int t = Convert.ToInt32(a[0]);
        a.RemoveAt(0);

        List<int> res = new List<int>();

        for (int a0 = 0; a0 < t; a0++)
        {
            int money = Convert.ToInt32(a[0]);
            a.RemoveAt(0);
            int n = Convert.ToInt32(a[0]);
            a.RemoveAt(0);
            var arr_temp = a[0].Split(' ').ToList();
            arr_temp.RemoveAt(arr_temp.Count() - 1);

            a.RemoveAt(0);
            var arr = Array.ConvertAll(arr_temp.ToArray(), int.Parse);

            Solve(arr, money);
        }
    }
}

