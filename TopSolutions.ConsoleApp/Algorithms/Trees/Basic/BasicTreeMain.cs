using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Algorithms.Trees.Basic
{
    public class BasicTreeMain
    {
        List<int> nodes = new List<int> { 10,22,34,56,89,100,134,237,258,310};
        public static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            BasicTreeMain btm = new();
            btm.InsertNodes(tree);

            // Perform traversals
            Console.Write("In-order traversal: ");
            tree.InOrderTraversal(); //10 22 34 56 89 100 134 237 258 310
            Console.WriteLine();

            Console.Write("Pre-order traversal: ");
            tree.PreOrderTraversal(); //10 22 34 56 89 100 134 237 258 310
            Console.WriteLine();

            Console.Write("Post-order traversal: ");
            tree.PostOrderTraversal(); //310 258 237 134 100 89 56 34 22 10
            Console.WriteLine();

            // Search for a value
            Console.WriteLine("Search 40: " + tree.Search(40)); // Output: True
            Console.WriteLine("Search 90: " + tree.Search(90)); // Output: False
        }

        private void InsertNodes(BinaryTree bt)             
        {
            foreach(var  node in nodes)
            {
                bt.Insert(node);
            }

        }
    }
}
