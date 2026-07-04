using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Algorithms.RedBlackTree.Node;

namespace TopSolutions.ConsoleApp.Algorithms.RedBlackTree.Operations
{
    internal class Rotation
    {
        // Implement left and right rotation methods for the Red-Black Tree
        public static TreeNode LeftRotate(TreeNode root, TreeNode x)
        {
            TreeNode y = x.Right;
            x.Right = y.Left;
            if (y.Left != null)
            {
                y.Left.Parent = x;
            }
            y.Parent = x.Parent;
            if (x.Parent == null)
            {
                root = y;
            }
            else if (x == x.Parent.Left)
            {
                x.Parent.Left = y;
            }
            else
            {
                x.Parent.Right = y;
            }
            y.Left = x;
            x.Parent = y;
            return root;
        }
        //right rotation method
        public static TreeNode RightRotate(TreeNode root, TreeNode y)
        {
            TreeNode x = y.Left;
            y.Left = x.Right;
            if (x.Right != null)
            {
                x.Right.Parent = y;
            }
            x.Parent = y.Parent;
            if (y.Parent == null)
            {
                root = x;
            }
            else if (y == y.Parent.Right)
            {
                y.Parent.Right = x;
            }
            else
            {
                y.Parent.Left = x;
            }
            x.Right = y;
            y.Parent = x;
            return root;
        }
    }
}
