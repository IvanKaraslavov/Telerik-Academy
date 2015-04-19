namespace BinarySearchTree
{
    using System;
    using System.Threading;

    class BinarySearchTreeTest
    {
        static void Main()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Test1: Creating of nodes");
                Console.ResetColor();
                Console.Write("Press any key to start the test...");
                Console.ReadKey();

                BinarySearchTree<int> tree = new BinarySearchTree<int>();
                Console.WriteLine("\n\nA new tree was created...");

                Thread.Sleep(1500);
                tree.Add(2);
                tree.Add(7);
                tree.Add(1);
                tree.Add(5);
                tree.Add(22);
                tree.Add(-7);
                tree.Add(4);
                Console.WriteLine("{0} nodes were added in the tree.\n", tree.Nodes.Count);

                Thread.Sleep(1500);
                Console.Write("The tree: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(tree);
                Console.ResetColor();

                Thread.Sleep(1500);
                for (int i = 0; i < tree.Nodes.Count; i++)
                {
                    Console.Write("Node{0}: ", i);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("{0}", tree.Nodes[i]);
                    Console.ResetColor();
                    Thread.Sleep(400);
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nTest2: Searching");
                Console.ResetColor();
                Console.Write("Press any key to start the test...");
                Console.ReadKey();

                Console.WriteLine();
                Search(tree, 2);
                Search(tree, 7);
                Search(tree, 14);
                Search(tree, 22);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nTest3: Cloning");
                Console.ResetColor();
                Console.Write("Press any key to start the test...");
                Console.ReadKey();

                BinarySearchTree<int> clone = tree.Clone() as BinarySearchTree<int>;
                Console.WriteLine("\n\nA clone was created...");

                Thread.Sleep(1500);
                Console.Write("The clone: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(clone);
                Console.ResetColor();

                CloningCheck(tree, clone, false);
               
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nTest4: Deleting");
                Console.ResetColor();
                Console.Write("Press any key to start the test...");
                Console.ReadKey();

                tree.Delete(2);
                tree.Delete(5);
                Console.WriteLine("\n\nTwo nodes with value 2 and 5 were deleted from the tree.");

                Thread.Sleep(1500);
                Console.Write("\nThe tree: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(tree);
                Console.ResetColor();
                Thread.Sleep(1000);
                Console.Write("The clone: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(clone);
                Console.ResetColor();

                CloningCheck(tree, clone, true);

                Thread.Sleep(1500);
                Console.WriteLine("\nThe HashCode for the tree: {0}", tree.GetHashCode());

                Thread.Sleep(1000);
                Console.WriteLine("The HashCode for the clone: {0}\n", clone.GetHashCode());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void CloningCheck(BinarySearchTree<int> tree, BinarySearchTree<int> clone, bool b)
        {
            Thread.Sleep(1500);
            Console.WriteLine("\nCloning check...{0,18}== test{0,8}!= test{0,8}Equal test", " ");
            Console.Write("{0}", (b) ? "The cloning after deletion is: " : "The cloning is: ");
            Thread.Sleep(1500);
            if (tree == clone)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(b ? "{0,10}" : "{0,25}", "OK");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(b ? "{0,10}" : "{0,25}", " X");
            }
            Thread.Sleep(1000);
            if (tree == clone)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("{0,15}", "OK");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0,15}", " X");
            }
            Thread.Sleep(1000);
            if (tree.Equals(clone))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0,18}", "OK");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0,18}", " X");
            }
            Console.ResetColor();
        }

        private static void Search(BinarySearchTree<int> tree, int num)
        {
            Thread.Sleep(1000);
            int value3 = num;
            TreeNode<int> search3 = tree.Search(value3);
            if (search3 != null)
            {
                Console.WriteLine("\nNode with value:{0} was found in the tree.", value3);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("{0,7}{1}", " ", search3);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("\nNode with value:{0} was not found in the tree.", value3);
                Console.ResetColor();
            }
        }
    }
}