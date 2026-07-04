using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Algorithms.RedBlackTree.Node
{
    //Red-black tree node class with color property and left, right, and parent pointers
    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public TreeNode Parent { get; set; }
        public bool IsRed { get; set; } // True for red, false for black
        public TreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
            Parent = null;
            IsRed = true; // New nodes are red by default
        }
    }
}
