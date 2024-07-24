namespace StackAndQueue.Queue
{
    public class QueueSolution
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

        private Node front;
        private Node rear;

        public QueueSolution()
        {
            front = null;
            rear = null;
        }

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (rear == null)
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            int result = front.Data;
            front = front.Next;
            if (front == null)
            {
                rear = null;
            }
            return result;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            return front.Data;
        }

        public bool IsEmpty()
        {
            return front == null;
        }

        
    }
}
