using System;
using StackAndQueue.Queue;
using StackAndQueue.Stack;
using StackAndQueue.ReverseStack;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            PerformStackOperations();
            Console.WriteLine("- - - - - - - - - -");
            PerformQueueOperations();
        }

        static void PerformStackOperations()
        {
            // Stack
            StackSolution stack = new StackSolution();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine("Stack Example:");
            Console.WriteLine("Top element is: " + stack.Peek());

            Console.WriteLine("Popped element: " + stack.Pop());
            Console.WriteLine("Popped element: " + stack.Pop());

            Console.WriteLine("Is stack empty? " + stack.IsEmpty());

            Console.WriteLine("Popped element: " + stack.Pop());

            Console.WriteLine("Is stack empty? " + stack.IsEmpty());

            try
            {
                stack.Pop();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Push elements again to reverse them
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            // Reverse the stack using the ReverseStackUsingQueue class
            ReverseStackUsingQueue reverser = new ReverseStackUsingQueue();
            reverser.Reverse(stack);
            Console.WriteLine("- - - - - - - - - -");
            Console.WriteLine("Stack after reversal:");
            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop());
            }
        }

        static void PerformQueueOperations()
        {
            // Queue
            QueueSolution queue = new QueueSolution();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine("Queue Example:");
            Console.WriteLine("Front element is: " + queue.Peek());

            Console.WriteLine("Dequeued element: " + queue.Dequeue());
            Console.WriteLine("Dequeued element: " + queue.Dequeue());

            Console.WriteLine("Is queue empty? " + queue.IsEmpty());

            Console.WriteLine("Dequeued element: " + queue.Dequeue());

            Console.WriteLine("Is queue empty? " + queue.IsEmpty());

            try
            {
                queue.Dequeue();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
