using System;
using static System.Net.Mime.MediaTypeNames;

namespace Linked_List_Implementation
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            // LinkedList Part 1
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
            // LinkedList Part 2
            // Remove Duplicates
            Console.WriteLine("\nList after removing duplicates:");
            list.RemoveDuplicate();
            list.PrintList();

            ///////////////////////////////////////////////////////////////////////
            // LinkedList Part 3
            // MergeSortedLists

            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();

            list1.Add(10);
            list1.Add(20);
            list1.Add(30);
            list2.Add(5);
            list2.Add(15);
            list2.Add(25);
            list2.Add(35);
            Console.WriteLine("\nList 1:");
            list1.PrintList();
            Console.WriteLine("\nList 2:");
            list2.PrintList();

            LinkedList mergedList = LinkedList.MergeSortedLists(list1, list2);
            Console.WriteLine("\nMerged List:");
            mergedList.PrintList();

            ///////////////////////////////////////////////////////////////////////
            // LinkedList Part 4
            // Rotate LinkedList

            LinkedList list3 = new LinkedList();
            list3.Add(1);
            list3.Add(2);
            list3.Add(3);
            list3.Add(4);
            list3.Add(5);
            list3.Add(6);

            LinkedList list4 = new LinkedList();
            list4.Add(10);
            list4.Add(20);
            list4.Add(30);
            list4.Add(40);
            list4.Add(50);

            LinkedList list5 = new LinkedList();
            list5.Add(5);
            list5.Add(10);
            list5.Add(15);
            list5.Add(20);

            Console.WriteLine("\nRotating the LinkedList by k positions:");

            Console.WriteLine("\nList 3:");
            Console.WriteLine("Original List:");
            list3.PrintList();
            LinkedList rotatedList = LinkedList.RotateLinkedList(list3, 2);
            Console.WriteLine("K Rotated List:");
            rotatedList.PrintList();

            Console.WriteLine("\nList 4:");
            Console.WriteLine("Original List:");
            list4.PrintList();
            LinkedList rotatedList1 = LinkedList.RotateLinkedList(list4, 3);
            Console.WriteLine("K Rotated List:");
            rotatedList1.PrintList();

            Console.WriteLine("\nList 5:");
            Console.WriteLine("Original List:");
            list5.PrintList();
            LinkedList rotatedList2 = LinkedList.RotateLinkedList(list5, 1);
            rotatedList2.PrintList();

        }

        // LinkedList Part 1
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
            // LinkedList Part 2
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

            ///////////////////////////////////////////////////////////////////////
            // LinkedList Part 3

            public static LinkedList MergeSortedLists(LinkedList list1, LinkedList list2)
            {
                LinkedList mergedList = new LinkedList();
                Node current1 = list1.Head;
                Node current2 = list2.Head;

                while (current1 != null && current2 != null)
                {
                    if (current1.Data <= current2.Data)
                    {
                        mergedList.Add(current1.Data);
                        current1 = current1.Next;
                    }
                    else
                    {
                        mergedList.Add(current2.Data);
                        current2 = current2.Next;
                    }
                }

                while (current1 != null)


                {
                    mergedList.Add(current1.Data);
                    current1 = current1.Next;
                }

                while (current2 != null)
                {
                    mergedList.Add(current2.Data);
                    current2 = current2.Next;
                }

                return mergedList;
            }


            public Node GetHead()
            {
                return Head;
            }

            public override string ToString()
            {
                var current = Head;
                var result = "Head";
                while (current != null)
                {
                    result += " -> " + current.Data;
                    current = current.Next;
                }
                result += " -> Null";
                return result;
            }

            ///////////////////////////////////////////////////////////////////////
            // LinkedList Part 4

            public static LinkedList RotateLinkedList(LinkedList list, int k)
            {
                if (list.Head == null || k == 0)
                    return list;

                Node current = list.Head;
                int length = 1;

 
                while (current.Next != null)
                {
                    current = current.Next;
                    length++;
                }

                k = k % length;

                if (k == 0)
                    return list;


                current.Next = list.Head;
                current = list.Head;
                for (int i = 1; i < k; i++)
                {
                    current = current.Next;
                }

                list.Head = current.Next;
                current.Next = null;

                return list;
            }



        }

    }
}

