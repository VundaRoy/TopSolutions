using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Algorithms.Trees.Basic
{
    public class BasicTreeMain
    {
        public static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();

            // Insert values
            tree.Insert(50);
            tree.Insert(30);
            tree.Insert(70);
            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(60);
            tree.Insert(80);

            // Perform traversals
            Console.Write("In-order traversal: ");
            tree.InOrderTraversal(); // Output: 20 30 40 50 60 70 80
            Console.WriteLine();

            Console.Write("Pre-order traversal: ");
            tree.PreOrderTraversal(); // Output: 50 30 20 40 70 60 80
            Console.WriteLine();

            Console.Write("Post-order traversal: ");
            tree.PostOrderTraversal(); // Output: 20 40 30 60 80 70 50
            Console.WriteLine();

            // Search for a value
            Console.WriteLine("Search 40: " + tree.Search(40)); // Output: True
            Console.WriteLine("Search 90: " + tree.Search(90)); // Output: False
        }
    }
}
