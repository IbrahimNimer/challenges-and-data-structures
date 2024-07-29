using StackAndQueue.Queue;
using StackAndQueue.Stack;

namespace StackAndQueue.ReverseStack
{
    public class ReverseStackUsingQueue
    {
        public void Reverse(StackSolution stack)
        {
            QueueSolution queue = new QueueSolution();

            // Pop elements from the stack and enqueue into the queue
            while (!stack.IsEmpty())
            {
                int element = stack.Pop();
                queue.Enqueue(element);
            }

            // Dequeue elements from the queue and push into the stack
            while (!queue.IsEmpty())
            {
                int element = queue.Dequeue();
                stack.Push(element);
            }
        }
    }
}
