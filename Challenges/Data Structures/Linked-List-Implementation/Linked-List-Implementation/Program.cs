using System;

namespace Linked_List_Implementation
{
    public class Program
    {

        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            //Add
            list.Add(10);
            list.Add(20);
            list.Add(30);


            //Print
            Console.WriteLine("Add:");
            list.PrintList();

            //Includes
            Console.WriteLine("Includes:");
            Console.WriteLine(list.Includes(10)); // Output: True
            Console.WriteLine(list.Includes(40)); // Output: False

            //Remove
            Console.WriteLine("Remove:");
            list.Remove(10);
            list.PrintList();

        }




        public class Node
        {

            public int Data { get; set; }

            public Node Next { get; set; }


            public Node(int data)
            {
                this.Data = data;
                this.Next = null;
            }
        }

        public class LinkedList
        {
            private Node Head;


            public LinkedList()
            {
                this.Head = null;
            }


            public void Add(int data)
            {
                Node newNode = new Node(data);
                if (Head == null)
                {
                    Head = newNode;
                }
                else
                {
                    Node current = Head;  

                    
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }


                    current.Next = newNode;
                }
            }


            public void PrintList()
            {
                Node current = Head;
                Console.Write("Head");
                while (current != null)
                {
                    Console.Write(" -> " + current.Data);
                    current = current.Next;
                }
                Console.WriteLine(" -> Null");
            }

            public bool Includes(int data)
            {
                Node current = Head;
                while (current != null)
                {
                    if (current.Data == data)
                    {
                        return true;
                    }
                    current = current.Next;
                }
                return false;


            }

            public void Remove(int data)
            {
                if (Head == null) return;

                if (Head.Data == data)
                {
                    Head = Head.Next;
                    return;
                }

                Node current = Head;
                while (current.Next != null && current.Next.Data != data)
                {
                    current = current.Next;
                }

                if (current.Next != null)
                {
                    current.Next = current.Next.Next;
                }
            }

        }


    }
}
