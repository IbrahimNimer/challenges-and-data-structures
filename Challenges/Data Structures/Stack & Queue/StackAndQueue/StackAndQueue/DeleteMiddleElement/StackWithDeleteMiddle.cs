using StackAndQueue.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue.DeleteMiddleElement
{
    public class StackWithDeleteMiddle
    {
        public void DeleteMiddle(StackSolution stack)
        {
            if (stack.IsEmpty())
            {
                Console.WriteLine("Stack is empty. No middle element to delete.");
                return;
            }

            int n = 0;
            StackSolution stacksaver1 = new StackSolution();

            while (!stack.IsEmpty())
            {
                stacksaver1.Push(stack.Pop());

                n++;

            }

            while (!stacksaver1.IsEmpty())
            {
                stack.Push(stacksaver1.Pop());
            }

          
            int middleElement = (n % 2 == 0) ? (n / 2) - 1 : n / 2;


            StackSolution stacksaver2 = new StackSolution();

            for (int i = 0; i < middleElement; i++)
            {
                stacksaver2.Push(stack.Pop());

            }
            stack.Pop();
            while (!stacksaver2.IsEmpty())
            {
                stack.Push(stacksaver2.Pop());
            }


        }
    }
}
