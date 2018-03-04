using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Data_Structures.LinkedLists
{
    public class Node
    {
        public int Data;
        public Node Next;
    }
    public class PrintElements
    {
        public static void Print(Node head)
        {
            var temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.Data.ToString());
                temp = temp.Next;
            }
        }
    }
}
