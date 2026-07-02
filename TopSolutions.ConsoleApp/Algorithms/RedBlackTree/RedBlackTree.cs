using NPOI.OpenXmlFormats.Dml.Chart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Algorithms.RedBlackTree
{
    public class RedBlackTree<T> where T : IComparable<T>
    {
        // Node class for the Red-Black Tree
        private class Node
        {
            public T Value;
            public Node Left;
            public Node Right;
            public Node Parent;
            public bool IsRed;
            public Node(T value)
            {
                Value = value;
                Left = null;
                Right = null;
                Parent = null;
                IsRed = true; // New nodes are red by default
            }
        }
        public RedBlackTree()
        {
            // Initialize the root of the tree
            root = null;

        }
        public void Insert(T value)
        {
            // Insert a new value into the Red-Black Tree
            Node newNode = new Node(value);
            if (root == null)
            {
                root = newNode;
                root.IsRed = false; // Root is always black
            }
            else
            {
                InsertNode(root, newNode);
                FixViolations(newNode);
            }
        }
        public void Remove(T value)
        {
            // Remove a value from the Red-Black Tree
            Node nodeToRemove = FindNode(root, value);
            if (nodeToRemove != null)
            {
                DeleteNode(nodeToRemove);
            }
        }
        //root 
        private Node root;
        private void InsertNode(Node current, Node newNode)
        {
            // Recursive insertion of a new node into the tree
            if (newNode.Value.CompareTo(current.Value) < 0)
            {
                if (current.Left == null)
                {
                    current.Left = newNode;
                    newNode.Parent = current;
                }
                else
                {
                    InsertNode(current.Left, newNode);
                }
            }
            else
            {
                if (current.Right == null)
                {
                    current.Right = newNode;
                    newNode.Parent = current;
                }
                else
                {
                    InsertNode(current.Right, newNode);
                }
            }
        }
        private void FixViolations(Node node)
        {
            // Fix any violations of the Red-Black Tree properties after insertion
            while (node != root && node.Parent.IsRed)
            {
                if (node.Parent == node.Parent.Parent.Left)
                {
                    Node uncle = node.Parent.Parent.Right;
                    if (uncle != null && uncle.IsRed)
                    {
                        // Case 1: Uncle is red
                        node.Parent.IsRed = false;
                        uncle.IsRed = false;
                        node.Parent.Parent.IsRed = true;
                        node = node.Parent.Parent;
                    }
                    else
                    {
                        if (node == node.Parent.Right)
                        {
                            // Case 2: Node is right child
                            node = node.Parent;
                            RotateLeft(node);
                        }
                        // Case 3: Node is left child
                        node.Parent.IsRed = false;
                        node.Parent.Parent.IsRed = true;
                        RotateRight(node.Parent.Parent);
                    }
                }
                else
                {
                    Node uncle = node.Parent.Parent.Left;
                    if (uncle != null && uncle.IsRed)
                    {
                        // Case 1: Uncle is red
                        node.Parent.IsRed = false;
                        uncle.IsRed = false;
                        node.Parent.Parent.IsRed = true;
                        node = node.Parent.Parent;
                    }
                    else
                    {
                        if (node == node.Parent.Left)
                        {
                            // Case 2: Node is left child
                            node = node.Parent;
                            RotateRight(node);
                        }
                        // Case 3: Node is right child
                        node.Parent.IsRed = false;
                        node.Parent.Parent.IsRed = true;
                        RotateLeft(node.Parent.Parent);
                    }
                }
            }
            root.IsRed = false; root.Parent.IsRed = false;
        }
        private void RotateLeft(Node node)
        {
            // Perform a left rotation on the given node
            Node rightChild = node.Right;
            node.Right = rightChild.Left;
            if (rightChild.Left != null)
            {
                rightChild.Left.Parent = node;
            }
            rightChild.Parent = node.Parent;
            if (node.Parent == null)
            {
                root = rightChild;
            }
            else if (node == node.Parent.Left)
            {
                node.Parent.Left = rightChild;
            }
            else
            {
                node.Parent.Right = rightChild;
            }
            rightChild.Left = node;
            node.Parent = rightChild;
        }
        private void RotateRight(Node node)
        {
            // Perform a right rotation on the given node
            Node leftChild = node.Left;
            node.Left = leftChild.Right;
            if (leftChild.Right != null)
            {
                leftChild.Right.Parent = node;
            }
            leftChild.Parent = node.Parent;
            if (node.Parent == null)
            {
                root = leftChild;
            }
            else if (node == node.Parent.Right)
            {
                node.Parent.Right = leftChild;
            }
            else
            {
                node.Parent.Left = leftChild;
            }
            leftChild.Right = node;
            node.Parent = leftChild;
        }
        private Node FindNode(Node current, T value)
        {
            // Find a node with the given value in the tree
            if (current == null)
            {
                return null;
            }
            int comparison = value.CompareTo(current.Value);
            if (comparison == 0)
            {
                return current;
            }
            else if (comparison < 0)
            {
                return FindNode(current.Left, value);
            }
            else
            {
                return FindNode(current.Right, value);
            }
        }
        private void DeleteNode(Node node)
        {
            // Delete a node from the tree and fix any violations
            Node y = node;
            Node x;
            bool yOriginalColor = y.IsRed;
            if (node.Left == null)
            {
                x = node.Right;
                Transplant(node, node.Right);
            }
            else if (node.Right == null)
            {
                x = node.Left;
                Transplant(node, node.Left); // Replace node with its left child
            }
            else
            {
                y = Minimum(node.Right);
                yOriginalColor = y.IsRed;
                x = y.Right;
                if (y.Parent == node)
                {
                    if (x != null)
                    {
                        x.Parent = y;
                    }
                }
                else
                {
                    Transplant(y, y.Right);
                    y.Right = node.Right;
                    y.Right.Parent = y;
                }
                Transplant(node, y);
                y.Left = node.Left;
                y.Left.Parent = y;
                y.IsRed = node.IsRed;
            }
            if (!yOriginalColor)
            {
                FixDeleteViolations(x);
            }
        }
        private void Transplant(Node u, Node v)
        {
            // Replace subtree rooted at u with subtree rooted at v
            if (u.Parent == null)
            {
                root = v;
            }
            else if (u == u.Parent.Left) // If u is the left child of its parent
            {
                u.Parent.Left = v;
            }
            else
            {
                u.Parent.Right = v;
            }
            if (v != null)
            {
                v.Parent = u.Parent;
            }
        }
        private Node Minimum(Node node)
        {
            // Find the minimum node in the subtree rooted at the given node
            while (node.Left != null)
            {
                node = node.Left;
            }
            return node;
        }
        private Node Maximum(Node node)
        {
            // Find the maximum node in the subtree rooted at the given node
            while (node.Right != null)
            {
                node = node.Right;
            }
            return node;
        }
        private void FixDeleteViolations(Node node)
        {
            // Fix any violations of the Red-Black Tree properties after deletion
            while (node != root && (node == null || !node.IsRed))
            {
                if (node == node.Parent.Left)
                {
                    Node sibling = node.Parent.Right;
                    if (sibling.IsRed)
                    {
                        sibling.IsRed = false;
                        node.Parent.IsRed = true;
                        RotateLeft(node.Parent);
                        sibling = node.Parent.Right;
                    }
                    if ((sibling.Left == null || !sibling.Left.IsRed) &&
                        (sibling.Right == null || !sibling.Right.IsRed))
                    {
                        sibling.IsRed = true;
                        node = node.Parent;
                    }
                    else
                    {
                        if (sibling.Right == null || !sibling.Right.IsRed)
                        {
                            sibling.Left.IsRed = false;
                            sibling.IsRed = true;
                            RotateRight(sibling);
                            sibling = node.Parent.Right;
                        }
                        sibling.IsRed = node.Parent.IsRed;
                        node.Parent.IsRed = false;
                        if (sibling.Right != null)
                        {
                            sibling.Right.IsRed = false;
                        }
                        RotateLeft(node.Parent);
                        node = root;
                    }
                }
                else
                {
                    Node sibling = node.Parent.Left;
                    if (sibling.IsRed)
                    {
                        sibling.IsRed = false;
                        node.Parent.IsRed = true;
                        RotateRight(node.Parent);
                        sibling = node.Parent.Left;
                    }
                    if ((sibling.Left == null || !sibling.Left.IsRed) &&
                        (sibling.Right == null || !sibling.Right.IsRed))
                    {
                        sibling.IsRed = true;
                        node = node.Parent;
                    }
                    else
                    {
                        if (sibling.Left == null || !sibling.Left.IsRed)
                        {
                            sibling.Right.IsRed = false;
                            sibling.IsRed = true;
                            RotateLeft(sibling);
                            sibling = node.Parent.Left;
                        }
                        sibling.IsRed = node.Parent.IsRed;
                        node.Parent.IsRed = false;
                        if (sibling.Left != null)
                        {
                            sibling.Left.IsRed = false;
                        }
                        RotateRight(node.Parent);
                        node = root;
                    }
                }
            }
            if (node != null)
            {
                node.IsRed = false; // Ensure the root is black
            }
        }
    }
    
}