using System;

namespace Linked_List_Implementation
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            //LinkedList Part 1
            // Add
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(20);  // Duplicate
            list.Add(10);  // Duplicate

            // Print
            Console.WriteLine("List after adding elements:");
            list.PrintList();

            // Includes
            Console.WriteLine("\nIncludes:");
            Console.WriteLine(list.Includes(10)); // Output: True
            Console.WriteLine(list.Includes(40)); // Output: False

            // Remove
            Console.WriteLine("\nList after removing 10:");
            list.Remove(10);
            list.PrintList();

            ///////////////////////////////////////////////////////////////////////
            //LinkedList Part 2
            // Remove Duplicates
            Console.WriteLine("\nList after removing duplicates:");
            list.RemoveDuplicate();
            list.PrintList();
        }


        //LinkedList Part 1
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

            ///////////////////////////////////////////////////////////////////////
            //LinkedList Part 2
            public void RemoveDuplicate()
            {
                try
                {
                    Node current = Head;

                    while (current != null && current.Next != null)
                    {
                        Node runner = current;
                        while (runner.Next != null)
                        {
                            if (current.Data == runner.Next.Data)
                            {
                                runner.Next = runner.Next.Next;
                            }
                            else
                            {
                                runner = runner.Next;
                            }
                        }
                        current = current.Next;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while removing duplicates: " + ex.Message);
                }
            }
        }
    }
}
