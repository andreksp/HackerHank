using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
public class IceCreamParlor
{
    public static List<int> Solve(int[] arr, int money)
    {
        List<int> res = new List<int>();
        int count = 0;

        foreach (var item in arr)
        {
            var r = money - item;
            var i = Array.BinarySearch(arr, r);

            if (i > -1)
            {
                res.Add(item);
                res.Add(arr[i]);

                break;
            }

            count++;
        }

        return res;
    }

    public static void Run()
    {
        string txt = File.ReadAllText(@"F:\Projetos\Visual Studio 2017\HackerRank\HackerRank\CrackingCodeInterview\IceCream2.txt");
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

            var ordered = arr.ToList().OrderBy(p => p).ToArray();
            res.Clear();

            var list = Solve(arr, money);

            if (list.Count() == 2)
            {
                var a1 = Array.FindIndex(arr, p => p == list[0]) + 1;
                var a2 = Array.FindIndex(arr, p => p == list[1]) + 1;

                if (a2 == a1)
                    a2 = Array.FindIndex(arr, a1, p => p == list[1]) + 1;

                res.Add(a1);
                res.Add(a2);                

                Console.WriteLine(string.Join(" ", res.OrderBy(p => p).ToArray()));
            }
        }
    }
}

