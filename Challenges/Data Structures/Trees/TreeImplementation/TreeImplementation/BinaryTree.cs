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


    }

}
