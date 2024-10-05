using System;
using Xunit;
using TreeImplementation;

namespace TreeImplementationTest
{
    public class MaxLevelNodesTest
    {
        [Fact]
        public void FindMaxLevelNodes_CorrectLevel_ReturnsMaxNodesLevel()
        {
            // Arrange
            var bTree = new BinaryTree(1);
            bTree.Root.Left = new Node(2);
            bTree.Root.Right = new Node(3);
            bTree.Root.Left.Left = new Node(4);
            bTree.Root.Left.Right = new Node(5);
            bTree.Root.Right.Right = new Node(7);
            bTree.Root.Left.Left.Left = new Node(8);
            bTree.Root.Left.Right.Left = new Node(9);
            bTree.Root.Right.Right.Left = new Node(10);

            // Act
            int maxLevel = bTree.FindMaxLevelNodes(); 

            // Assert
            Assert.Equal(2, maxLevel); 
        }

        [Fact]
        public void FindMaxLevelNodes_AllLevelsSameNumberOfNodes_ReturnsFirstLevelWithMaxNodes()
        {
            // Arrange
            var bTree = new BinaryTree(1);
            bTree.Root.Left = new Node(2);
            bTree.Root.Right = new Node(3);
            bTree.Root.Left.Left = new Node(4);
            bTree.Root.Left.Right = new Node(5);
            bTree.Root.Right.Right = new Node(6);
            bTree.Root.Left.Left.Left = new Node(7);
            bTree.Root.Left.Left.Right = new Node(8);
            bTree.Root.Right.Left = new Node(9);
            bTree.Root.Right.Right.Left = new Node(10);
            bTree.Root.Right.Right.Right = new Node(11);

            // Act
            int result = bTree.FindMaxLevelNodes();

            // Assert
            Assert.Equal(2, result); 
        }
    }
}
