namespace TreeImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PerformTree();
            Console.WriteLine("- - - - - - - - - - \n- - - - - - - - - -");
            PerformMirror();
            Console.WriteLine("- - - - - - - - - - \n- - - - - - - - - -");
            PerformLeafSum();
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
            Console.WriteLine();

        }

        public static void PerformMirror()
        {

            var bTree = new BinarySearchTree(4);
            bTree.Root.Left = new Node(8);
            bTree.Root.Right = new Node(7);
            bTree.Root.Left.Left = new Node(12);
            bTree.Root.Left.Right = new Node(9);

            Console.WriteLine("MirrorTree Challenge:");
            Console.WriteLine();

            // Print the original BinaryTree
            Console.WriteLine($"1)Original Binary Tree:");
            Console.WriteLine();
            bTree.PrintInOrder();
            Console.WriteLine();


            // Mirror the BinaryTree
            bTree.MirrorTree(bTree.Root);

            // Print the mirrored BinaryTree
            Console.WriteLine("2)Mirrored Binary Tree:");
            Console.WriteLine();
            bTree.PrintInOrder();
            Console.WriteLine();



        }


        public static void PerformLeafSum()
        {
            var bTree = new BinaryTree(9); 
            bTree.Root.Left = new Node(8);
            bTree.Root.Right = new Node(12);
            bTree.Root.Left.Left = new Node(3);
            bTree.Root.Left.Right = new Node(7);
            bTree.Root.Right.Left = new Node(17);
            bTree.Root.Right.Right = new Node(23);
            bTree.Root.Left.Left.Right = new Node(4);

            Console.WriteLine("Sum of leaf nodes Challenge:");
            Console.WriteLine(bTree.LeafSum(bTree.Root)); 
        }




    }
}
