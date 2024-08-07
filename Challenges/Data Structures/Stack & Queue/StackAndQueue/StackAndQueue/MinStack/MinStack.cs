using StackAndQueue.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue.MinStack
{
    public class MinStackClass
    {

        StackSolution stack = new StackSolution();
        StackSolution minStack = new StackSolution();

        public void Push(int data)
        {
            stack.Push(data);
            if (minStack.IsEmpty() || data <= minStack.Peek())
            {
                minStack.Push(data);
            }
        }

        public int Pop()
        {
            if (stack.IsEmpty())
                throw new InvalidOperationException("Stack is empty.");

            int data = stack.Pop();
            if (data == minStack.Peek())
            {
                minStack.Pop();
            }
            return data;
        }

        public int Top()
        {
            return stack.Peek();
        }

        public bool IsEmpty()
        {
            return stack.IsEmpty();
        }

        public int GetMin()
        {
            if (minStack.IsEmpty())
                throw new InvalidOperationException("Stack is empty.");

            return minStack.Peek();
        }

        public void PrintStack()
        {
            Console.WriteLine(stack.ToString());
        }

    }
}
