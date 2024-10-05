using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TreeImplementation
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree(int rootValue)
        {
            Root = new Node(rootValue);
        }

        public void PreOrder(Node node)
        {
            if (node == null) return;

            Console.Write(node.Value + "  ");
            PreOrder(node.Left);
            PreOrder(node.Right);
        }

        public void InOrder(Node node)
        {
            if (node == null) return;

            InOrder(node.Left);
            Console.Write(node.Value + "  ");
            InOrder(node.Right);
        }

        public void PostOrder(Node node)
        {
            if (node == null) return;

            PostOrder(node.Left);
            PostOrder(node.Right);
            Console.Write(node.Value + "  ");
        }

        public void Print()
        {
            if (Root == null)
            {
                Console.WriteLine("The tree is empty.");
                return;
            }

            PrintRecursive(Root, "", true);
        }

        private void PrintRecursive(Node node, string indent, bool isLast)
        {
            if (node != null)
            {
                Console.Write(indent);
                if (isLast)
                {
                    Console.Write("└─");
                    indent += "  ";
                }
                else
                {
                    Console.Write("├─");
                    indent += "│ ";
                }

                Console.WriteLine(node.Value);

                PrintRecursive(node.Left, indent, false);
                PrintRecursive(node.Right, indent, true);
            }
        }


        public void MirrorTree(Node node)
        {
            if (node == null) return;


            Node temp = node.Left;
            node.Left = node.Right;
            node.Right = temp;


            MirrorTree(node.Left);
            MirrorTree(node.Right);
        }

        int FirstMax = 0;
        int SecMax = 0;
        public int FindSecondMax(Node node)
        {
            if (node == null) return SecMax;
            if (node.Value > FirstMax)
            {
                SecMax = FirstMax;
                FirstMax = node.Value;
                if (node.Left == null && node.Right == null)
                {
                    return FirstMax;
                }
                if (node.Right != null)
                {
                    FindSecondMax(node.Right);
                }
                if (node.Right == null)
                {
                    FindSecondMax(node.Left);
                }
            }
            else if (node.Value > SecMax && node.Value < FirstMax)
            {
                SecMax = node.Value;
            }
            if (node.Left != null)
            {
                FindSecondMax(node.Left);
            }
            if (node.Right != null)
            {
                FindSecondMax(node.Right);
            }
            return SecMax;
        }



        public int LeafSum(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            if (node.Left == null && node.Right == null)
            {
                return node.Value;
            }

            return LeafSum(node.Left) + LeafSum(node.Right);
        }



        public static void Helper(List<int> largest,
                   Node root, int level)
        {
            if (root == null)
                return;


            if (level == largest.Count)
                largest.Add(root.Value);

            else


                largest[level] = Math.Max(largest[level], root.Value);


            Helper(largest, root.Left, level + 1);
            Helper(largest, root.Right, level + 1);
        }

        public static List<int> LargestValues(Node root)
        {
            List<int> level = new List<int>();
            Helper(level, root, 0);
            return level;
        }


        //View Right
        private int maxLevel = 0;

        public void PrintRightView()
        {
            try
            {
                if (Root == null)
                {
                    Console.WriteLine("The tree is empty.");
                    return;
                }

                PrintRightViewUtil(Root, 1);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public void PrintRightViewUtil(Node node, int currentLevel)
        {
            if (node == null)
                return;


            if (maxLevel < currentLevel)
            {
                Console.WriteLine(node.Value);
                maxLevel = currentLevel;
            }


            PrintRightViewUtil(node.Right, currentLevel + 1);
            PrintRightViewUtil(node.Left, currentLevel + 1);
        }


        //Max Level Nodes
        // Helper function to get the height of the tree
        public int GetHeight(Node node)
        {
            if (node == null)
                return 0;

            int leftHeight = GetHeight(node.Left);
            int rightHeight = GetHeight(node.Right);

            return Math.Max(leftHeight, rightHeight) + 1;
        }

        // Helper function to count nodes at a given level
        public int CountNodesAtLevel(Node node, int level)
        {
            if (node == null)
                return 0;

            if (level == 0)
                return 1;

            int leftCount = CountNodesAtLevel(node.Left, level - 1);
            int rightCount = CountNodesAtLevel(node.Right, level - 1);

            return leftCount + rightCount;
        }

        // Method to find the level with the maximum number of nodes
        public int FindMaxLevelNodes()
        {
            if (Root == null)
            {
                Console.WriteLine("The tree is empty.");
                return -1; // Return -1 for an empty tree
            }

            int treeHeight = GetHeight(Root);
            int maxNodes = 0;
            int maxLevel = 0;

            for (int level = 0; level < treeHeight; level++)
            {
                int nodeCount = CountNodesAtLevel(Root, level);
                if (nodeCount > maxNodes)
                {
                    maxNodes = nodeCount;
                    maxLevel = level;
                }
            }

            return maxLevel;
        }




    }
}
