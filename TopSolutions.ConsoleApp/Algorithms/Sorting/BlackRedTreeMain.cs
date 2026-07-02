using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Algorithms.Sorting
{
    public class BlackRedTreeMain
    {
        // Implement a Red-Black Tree in C# and demonstrate its usage with insertion and traversal methods.
        static void Main(string[] args)
        {
            RedBlackTree<int> rbt = new RedBlackTree<int>();
            rbt.Insert(10);
            rbt.Insert(20);
            rbt.Insert(30);
            rbt.Insert(15);
            Console.WriteLine("In-order Traversal of the Red-Black Tree:");
            rbt.InOrderTraversal();
        }
    }
}
