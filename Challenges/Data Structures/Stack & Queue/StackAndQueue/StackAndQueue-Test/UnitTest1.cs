using StackAndQueue.Queue;
using StackAndQueue.Stack;
using StackAndQueue.ReverseStack;
using Xunit;
using StackAndQueue.DeleteMiddleElement;

public class StackAndQueueTests
{
    [Fact]
    public void Stack_Push_PushesNodeOntoStack()
    {
        // Arrange
        var stack = new StackSolution();

        // Act
        stack.Push(10);

        // Assert
        Assert.False(stack.IsEmpty());
        Assert.Equal(10, stack.Peek());
    }

    [Fact]
    public void Stack_Pop_PopsNodeFromStack()
    {
        // Arrange
        var stack = new StackSolution();
        stack.Push(10);
        stack.Push(20);

        // Act
        int popped = stack.Pop();

        // Assert
        Assert.Equal(20, popped);
        Assert.Equal(10, stack.Peek());
    }

    [Fact]
    public void Stack_IsEmpty_ReturnsTrueIfStackIsEmpty()
    {
        // Arrange
        var stack = new StackSolution();

        // Act & Assert
        Assert.True(stack.IsEmpty());

        stack.Push(10);
        Assert.False(stack.IsEmpty());

        stack.Pop();
        Assert.True(stack.IsEmpty());
    }

    [Fact]
    public void Queue_Enqueue_EnqueuesNodeIntoQueue()
    {
        // Arrange
        var queue = new QueueSolution();

        // Act
        queue.Enqueue(10);

        // Assert
        Assert.False(queue.IsEmpty());
        Assert.Equal(10, queue.Peek());
    }

    [Fact]
    public void Queue_Dequeue_DequeuesNodeFromQueue()
    {
        // Arrange
        var queue = new QueueSolution();
        queue.Enqueue(10);
        queue.Enqueue(20);

        // Act
        int dequeued = queue.Dequeue();

        // Assert
        Assert.Equal(10, dequeued);
        Assert.Equal(20, queue.Peek());
    }

    [Fact]
    public void Queue_IsEmpty_ReturnsTrueIfQueueIsEmpty()
    {
        // Arrange
        var queue = new QueueSolution();

        // Act & Assert
        Assert.True(queue.IsEmpty());

        queue.Enqueue(10);
        Assert.False(queue.IsEmpty());

        queue.Dequeue();
        Assert.True(queue.IsEmpty());
    }



    //ReverseStackUsingQueue Test
    [Fact]
    public void ReverseStack_MultipleElements()
    {
        // Arrange
        var stack = new StackSolution();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        var reverser = new ReverseStackUsingQueue();

        // Act
        reverser.Reverse(stack);

        // Assert
        Assert.Equal(10, stack.Pop());
        Assert.Equal(20, stack.Pop());
        Assert.Equal(30, stack.Pop());
        Assert.True(stack.IsEmpty());
    }

    [Fact]
    public void ReverseStack_SingleElement()
    {
        // Arrange
        var stack = new StackSolution();
        stack.Push(10);

        var reverser = new ReverseStackUsingQueue();

        // Act
        reverser.Reverse(stack);

        // Assert
        Assert.Equal(10, stack.Pop());
        Assert.True(stack.IsEmpty());
    }

    [Fact]
    public void ReverseStack_EmptyStack()
    {
        // Arrange
        var stack = new StackSolution();

        var reverser = new ReverseStackUsingQueue();

        // Act
        reverser.Reverse(stack);

        // Assert
        Assert.True(stack.IsEmpty());
    }


    //DeletionTest
    public class StackWithDeleteMiddleTests
    {
        [Fact]
        public void DeleteMiddle_OddSizedStack_RemovesMiddleElement()
        {
            // Arrange
            StackSolution stack = new StackSolution();
            StackWithDeleteMiddle stackWithDeleteMiddle = new StackWithDeleteMiddle();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            // Act
            stackWithDeleteMiddle.DeleteMiddle(stack);

            // Assert
            Assert.Equal("Stack: Top -> 5 -> 4 -> 2 -> 1", stack.ToString());
        }

        [Fact]
        public void DeleteMiddle_EvenSizedStack_RemovesMiddleElement()
        {
            // Arrange
            StackSolution stack = new StackSolution();
            StackWithDeleteMiddle stackWithDeleteMiddle = new StackWithDeleteMiddle();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

            // Act
            stackWithDeleteMiddle.DeleteMiddle(stack);

            // Assert
            Assert.Equal("Stack: Top -> 6 -> 5 -> 3 -> 2 -> 1", stack.ToString());
        }
    }
}
