namespace TreeImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PerformTree();
        }


        public static void PerformTree()
        {

            var bst = new BinarySearchTree(10);


            bst.Add(5);
            bst.Add(15);
            bst.Add(3);
            bst.Add(7);
            bst.Add(12);
            bst.Add(18);


            //BT
            Console.WriteLine("1) Binary Tree:");
            bst.PrintPreOrder();
            Console.WriteLine();
            bst.PrintInOrder();
            Console.WriteLine();
            bst.PrintPostOrder();
            Console.WriteLine();

            Console.WriteLine("- - - - - - - - - - \n- - - - - - - - - -");



            //BST
            Console.WriteLine("2) Binary Search Tree (BST) Structure:");
            Console.WriteLine();
            bst.Print();


            Console.WriteLine("Contains 7: " + bst.Contains(7));
            Console.WriteLine("Contains 20: " + bst.Contains(20));

            bst.Remove(7);
            Console.WriteLine("After removing 7:");
            Console.WriteLine();
            bst.Print();

            bst.Remove(15);
            Console.WriteLine("After removing 15:");
            Console.WriteLine();
            bst.Print();
            


        }

    }
}
