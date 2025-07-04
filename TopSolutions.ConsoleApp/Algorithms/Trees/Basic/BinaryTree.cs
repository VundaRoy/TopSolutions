using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Algorithms.Trees.Basic
{
    public class BinaryTree
    {
        public TreeNode Root { get; private set; }
        public BinaryTree()
        {
            Root = null;
        }
        public void Insert(int value)
        {
            Root = InsertRec(Root, value);
        }
        private TreeNode InsertRec(TreeNode root, int value)
        {
            if(root == null)
            {
                root = new TreeNode(value);
                return root;
            }
            if(value < root.Value)
            {
                root.Left = InsertRec(root.Left, value);
            }
            else if(value > root.Value)
            {
                root.Right = InsertRec(root.Right, value);
            }
            return root;
        }
        public void InOrderTraversal()
        {
            InOrderRec(Root);
        }
        private void InOrderRec(TreeNode root)
        {
            if(Root != null)
            {
                InOrderRec(root.Left);
                Console.Write(root.Value + " ");
                InOrderRec(root.Right);
            }
        }
        public void PreOrderTraversal()
        {
            PreOrderRec(Root);
        }
        private void PreOrderRec(TreeNode root)
        {
            if (root != null)
            {
                Console.Write(root.Value + " ");
                PreOrderRec(root.Left);
                PreOrderRec(root.Right);
            }
        }
        public void PostOrderTraversal()
        {
            PostOrderRec(Root);
        }
        private void PostOrderRec(TreeNode root)
        {
            if (root != null)
            {
                PostOrderRec(root.Left);
                PostOrderRec(root.Right);
                Console.Write(root.Value + " ");
            }
        }
        public bool Search(int value)
        {
            return SearchRec(Root, value);
        }
        private bool SearchRec(TreeNode root, int value)
        {
            if (root == null)
            {
                return false;
            }

            if (root.Value == value)
            {
                return true;
            }

            return value < root.Value ? SearchRec(root.Left, value) : SearchRec(root.Right, value);
        }
    }
}
