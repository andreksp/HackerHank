using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.CrackingCodeInterview
{
    class TriesContacts
    {
        public class Node
        {
            public Dictionary<char, Node> Nodes = new Dictionary<char, Node>();

            public bool IsComplete { get; set; }
            public int CountCompletesAbove { get; set; }
        }

        static Dictionary<char, Node> startNodes = new Dictionary<char, Node>();

        public static void Run()
        {
            string txt = File.ReadAllText(@"F:\Projetos\Visual Studio 2017\HackerRank\HackerRank\CrackingCodeInterview\tries.txt");
            string[] stringSeparators = new string[] { "\r\n" };
            var a = new List<string>(txt.Split(stringSeparators, StringSplitOptions.None));

            int n = Convert.ToInt32(a[0]);
            a.RemoveAt(0);          
           
            for (int a0 = 0; a0 < n; a0++)
            {
                string[] tokens_op = a[a0].Split(' ');
                string op = tokens_op[0];
                string contact = tokens_op[1];

                if (op == "add")
                { 
                    AddWord(contact);
                }
                else if (op == "find")
                {  
                    Console.WriteLine(FindWord(contact));
                }
            }
        }

        public static int FindWord(string contact)
        {
            var chars = contact.ToCharArray().ToList();
            Node node = FindNode(chars, startNodes);
            if (node == null)
                return 0;
            else
            {
                return CountCompletes(node.Nodes) + (node.IsComplete ? 1 : 0);

            }
        }

        public static int CountCompletes(Dictionary<char, Node> node)
        {
            int count = 0;

            if (node != null)
            {
                foreach (var n in node.Keys)
                {
                    var currentNode = node[n];
                    count += currentNode.CountCompletesAbove;
                }
            }
            return count;
        }
        

        public static Node FindNode(List<char> chars, Dictionary<char, Node> node)
        {
            var c = chars.First();
            chars.RemoveAt(0);

            Node nextNode = null;
            if (node.ContainsKey(c))
            {
                nextNode = node[c];

                if (chars.Count() == 0)
                {
                    return nextNode;
                }
                else if (chars.Count() > 0)
                {
                    return FindNode(chars, nextNode.Nodes);
                }
            }

            return null;
        }

        public static void AddWord(string contact)
        {
            var chars = contact.ToCharArray().ToList();

            AddChar(chars, startNodes);
        }

        public static void AddChar(List<char> chars, Dictionary<char, Node> node)
        {
            var c = chars.First();
            chars.RemoveAt(0);

            Dictionary<char, Node> nextNode = null;
            if (!node.ContainsKey(c))
            {
                var n = new Node();
                nextNode = new Dictionary<char, Node>();
                n.Nodes = nextNode;
                n.CountCompletesAbove++;
                node.Add(c, n);
            }
            else
            {
                nextNode = node[c].Nodes;
                node[c].CountCompletesAbove++;
            }

            if (chars.Count() > 0)
            {
                AddChar(chars, nextNode);
            }
            else
            {
                node[c].IsComplete = true;
            }
        }
    }
}
