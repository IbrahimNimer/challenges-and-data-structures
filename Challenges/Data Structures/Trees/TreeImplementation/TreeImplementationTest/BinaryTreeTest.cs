using TreeImplementation;

namespace TreeImplementationTest
{
    public class BinaryTreeTest
    {
        [Fact]
        public void TestPreOrderTraversal()
        {
            // Arrange
            var tree = new BinarySearchTree(10);
            tree.Add(5);
            tree.Add(15);
            tree.Add(3);
            tree.Add(7);
            tree.Add(12);
            tree.Add(18);

            var expectedOutput = "10  5  3  7  15  12  18";
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            tree.PrintPreOrder();

            // Assert
            var actualOutput = stringWriter.ToString().Trim();

            // Remove header "Pre-Order Traversal:"
            var cleanOutput = actualOutput.Replace("Pre-Order Traversal:", "").Trim();

            Assert.Equal(expectedOutput, cleanOutput);
        }


        [Fact]
        public void TestInOrderTraversal()
        {
            // Arrange
            var tree = new BinarySearchTree(10);
            tree.Add(5);
            tree.Add(15);
            tree.Add(3);
            tree.Add(7);
            tree.Add(12);
            tree.Add(18);

            var expectedOutput = "3  5  7  10  12  15  18";
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            tree.PrintInOrder();

            // Assert
            var actualOutput = stringWriter.ToString().Trim();

            // Remove header "In-Order Traversal:"
            var cleanOutput = actualOutput.Replace("In-Order Traversal:", "").Trim();

            Assert.Equal(expectedOutput, cleanOutput);
        }

        [Fact]
        public void TestPostOrderTraversal()
        {
            // Arrange
            var tree = new BinarySearchTree(10);
            tree.Add(5);
            tree.Add(15);
            tree.Add(3);
            tree.Add(7);
            tree.Add(12);
            tree.Add(18);

            var expectedOutput = "3  7  5  12  18  15  10";
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            tree.PrintPostOrder();

            // Assert
            var actualOutput = stringWriter.ToString().Trim();

            // Remove header "Post-Order Traversal:"
            var cleanOutput = actualOutput.Replace("Post-Order Traversal:", "").Trim();

            Assert.Equal(expectedOutput, cleanOutput);
        }
    }
}