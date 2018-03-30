using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.CrackingCodeInterview
{
    public class IsBinarySearchTree
    {
        public class Node
        {
            public int data;
            public Node left;
            public Node right;
        }

        bool checkBST(Node root)
        {
            return checkBST(root, int.MinValue, int.MaxValue);
        }

        bool checkBST(Node root, int min, int max)
        {
            if (root == null) return true;
            return root.data > min && root.data < max &&
                 checkBST(root.left, min, root.data) &&
                 checkBST(root.right, root.data, max);
        }
    }
}
