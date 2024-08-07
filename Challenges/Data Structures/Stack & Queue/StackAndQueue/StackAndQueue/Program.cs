using System;
using StackAndQueue.Queue;
using StackAndQueue.Stack;
using StackAndQueue.ReverseStack;
using StackAndQueue.DeleteMiddleElement;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            PerformStackOperations();
            Console.WriteLine("- - - - - - - - - -");
            PerformQueueOperations();
            Console.WriteLine("- - - - - - - - - -");
            PerformMinStackOperations();
        }

        static void PerformStackOperations()
        {
            // Stack
            StackSolution stack = new StackSolution();
            StackWithDeleteMiddle stackWithDeleteMiddle = new StackWithDeleteMiddle();

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




            //Reverse Challenge
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




            //Delete Challenge
            stack.Push(7);
            stack.Push(14);
            stack.Push(3);
            stack.Push(8);
            stack.Push(5);
            Console.WriteLine("- - - - - - - - - -");
            Console.WriteLine("The Stack before deletion:");
            Console.WriteLine(stack); 
            stackWithDeleteMiddle.DeleteMiddle(stack);
            Console.WriteLine("The Stack After deletion:");
            Console.WriteLine(stack); 

            stack.Push(2);
            stack.Push(9);
            stack.Push(11);
            Console.WriteLine("The Stack before deletion:");
            Console.WriteLine(stack); 
            stackWithDeleteMiddle.DeleteMiddle(stack);
            Console.WriteLine("The Stack after deletion:");
            Console.WriteLine(stack);
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



        static void PerformMinStackOperations()
        {
            StackAndQueue.MinStack.MinStackClass minStack = new StackAndQueue.MinStack.MinStackClass();
            Console.WriteLine("PerformMinStackOperations:");
            
            minStack.Push(15); 
            minStack.Push(7);
            minStack.Push(12); 
            minStack.Push(3);  

            minStack.PrintStack(); 

           
            int min = minStack.GetMin(); 
            Console.WriteLine($"Min: {min}");

            
            int popped = minStack.Pop(); 
            Console.WriteLine($"Popped: {popped}");
            minStack.PrintStack(); 

            
            min = minStack.GetMin(); 
            Console.WriteLine($"Min: {min}");

           
            int peeked = minStack.Top(); 
            Console.WriteLine($"Top: {peeked}");

           
            minStack.Push(2);  
            minStack.PrintStack(); 

            
            min = minStack.GetMin(); 
            Console.WriteLine($"Min: {min}");

            
            bool isEmpty = minStack.IsEmpty(); 
            Console.WriteLine($"Is stack empty? {isEmpty}");

        }
    }
}
