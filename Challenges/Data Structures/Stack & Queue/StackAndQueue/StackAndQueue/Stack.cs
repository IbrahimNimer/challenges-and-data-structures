namespace StackAndQueue.Stack
{
    public class StackSolution
    {


        public class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }

            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node top;

        public StackSolution()
        {
            top = null;
        }

        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            int result = top.Data;
            top = top.Next;
            return result;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return top.Data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        
    }
}
