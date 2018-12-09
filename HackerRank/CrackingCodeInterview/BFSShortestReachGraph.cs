using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.CrackingCodeInterview
{
    public class BFSShortestReachGraph
    {

        public class Node
        {
            public int Num { get; set; }
            public int Sum { get; set; }

            public Node(int num)
            {
                this.Num = num;
            }

            public Dictionary<int, Node> nodes = new Dictionary<int, Node>();

            public bool IsVisited { get; set; }
        }



        public static void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (var q = 0; q < n; q++)
            {
                int nodes = 0;
                int edges = 0;

                int start = 0;
                Dictionary<int, Node> allNodes = new Dictionary<int, Node>();

                while (true)
                {
                    string[] a_temp = Console.ReadLine().Split(' ');
                    int[] a = Array.ConvertAll(a_temp, Int32.Parse);

                    if (nodes == 0)
                    {
                        nodes = a[0];
                        edges = a[1];
                    }
                    else if (a.Length == 1)
                    {
                        start = a[0];
                        break;
                    }
                    else
                    {
                        Node n1 = null;
                        if (!allNodes.ContainsKey(a[0]))
                        {
                            n1 = new Node(a[0]);
                            allNodes.Add(a[0], n1);
                        }
                        else
                        {
                            n1 = allNodes[a[0]];
                        }

                        Node n2 = null;
                        if (!allNodes.ContainsKey(a[1]))
                        {
                            n2 = new Node(a[1]);
                            allNodes.Add(a[1], n2);
                        }
                        else
                        {
                            n2 = allNodes[a[1]];
                        }


                        if (!n1.nodes.ContainsKey(n2.Num))
                        {
                            n1.nodes.Add(n2.Num, n2);
                        }

                        if (!n2.nodes.ContainsKey(n1.Num))
                        {
                            n2.nodes.Add(n1.Num, n1);
                        }
                    }
                }

                FindSolution(start, nodes, allNodes);

                Console.WriteLine("");

            }

        }

        public static void FindSolution(int start, int nodes, Dictionary<int, Node> allNodes)
        {
            Node startNode = null;
            if (allNodes.ContainsKey(start))
            {
                startNode = allNodes[start];
            }

            nodeQueued.Enqueue(startNode);
            Find(start, nodes, allNodes);
        }

        static Queue<Node> nodeQueued = new Queue<Node>();

        public static void Find(int start, int nodes, Dictionary<int, Node> allNodes)
        {
            Dictionary<int, int> res = new Dictionary<int, int>();

            while (nodeQueued.Count > 0)
            {
                var n = nodeQueued.Dequeue();
                if (n != null)
                {
                    n.IsVisited = true;

                    foreach (var node in n.nodes)
                    {
                        if (node.Value != null && !node.Value.IsVisited && !res.ContainsKey(node.Value.Num))
                        {
                            node.Value.Sum = n.Sum + 6;

                            res.Add(node.Value.Num, node.Value.Sum);

                            nodeQueued.Enqueue(node.Value);
                        }
                    }
                }
            }

            for (int i = 1; i <= nodes; i++)
            {
                if (!allNodes.ContainsKey(i))
                    allNodes.Add(i, new Node(i));
            }

            foreach (var node in allNodes.OrderBy(i => i.Key))
            {
                if (node.Key != start)
                {
                    if (res.ContainsKey(node.Key))
                    {
                        Console.Write(res[node.Key].ToString() + " ");
                    }
                    else
                    {
                        Console.Write("-1 ");
                    }
                }
            }
        }
    }
}
