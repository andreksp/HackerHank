using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;

public class RunningMedian
{
    public static double Median(List<int> list)
    {
        int size = list.Count();
        if (size % 2 == 0)
        {
            return (list[size / 2 - 1] + list[size / 2]) / 2.0;
        }
        else
        {
            return list[size / 2];
        }
    }

    public static void AddToSortedList(List<int> list, int v)
    {
        if (list.Count == 0)
        {
            list.Add(v);
        }
        else
        {
            int min = 0;
            int max = list.Count - 1;

            int m = (max + min) / 2;

            while (min <= max)
            {
                if (v < list[m])
                    max = m - 1;
                else
                    min = m + 1;
                m = (max + min) / 2;
            }


            if (v < list[m])
                list.Insert(m, v);
            else if (m + 1 >= list.Count() || v < list[m + 1])
                list.Insert(m + 1, v);
        }

    }

    public static void Run()
    {
        string txt = File.ReadAllText(@"F:\Projetos\Visual Studio 2017\HackerRank\HackerRank\CrackingCodeInterview\RunningMedian.txt");
        var a = new List<int>(Array.ConvertAll(txt.Split('\n'), s => int.Parse(s)));

        int n = a.Count();

        List<int> newLine = new List<int>();
        double result = 0;
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            var newValue = a[(int)i];

            AddToSortedList(newLine, newValue);

            count++;

            int m = count / 2;

            if (count % 2 == 0)
            {
                result = (newLine.ElementAt(m - 1) + newLine.ElementAt(m)) / 2.0;
            }
            else
            {
                result = newLine.ElementAt(m);
            }
            Console.WriteLine(String.Format("{0:F1}", result));
        }
    }
}