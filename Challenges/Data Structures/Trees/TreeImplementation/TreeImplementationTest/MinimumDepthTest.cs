using System;
using TreeImplementation;
using Xunit;

namespace TreeImplementationTest
{
    public class MinimumDepthTest
    {
        [Fact]
        public void Test_MinimumDepth_WithMultipleNodes_VaryingDepths()
        {
            // Arrange
            var bTree = new BinaryTree(1);
            bTree.Root.Left = new Node(2);
            bTree.Root.Right = new Node(3);
            bTree.Root.Left.Left = new Node(4);
            bTree.Root.Left.Right = new Node(5);

            // Act
            int minDepth = bTree.FindMinimumDepth();

            // Assert
            Assert.Equal(2, minDepth);  
        }

        [Fact]
        public void Test_MinimumDepth_EmptyTree()
        {
            // Arrange
            var bTree = new BinaryTree(null); 

            // Act
            int minDepth = bTree.FindMinimumDepth();

            // Assert
            Assert.Equal(0, minDepth);  
        }
    }
}
