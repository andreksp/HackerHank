using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.CrackingCodeInterview
{
    class DetectCycle
    {
        class Node
        {
            public int data;
            public Node next;
        }

        bool hasCycle(Node node)
        {
            Node t = node;

            int count = 0;

            if (node == null)
                return false;


            List<Node> list = new List<Node>();

            while (t != null)
            {
                list.Add(t);

                if (count > 100)
                {
                    return true;
                }


                t = t.next;

                if (list.Contains(t))
                {
                    return true;
                }


                count++;
            }

            return false;
        }
    }
}
