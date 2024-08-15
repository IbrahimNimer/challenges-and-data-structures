using System;
using System.IO;
using Xunit;
using TreeImplementation;

namespace TreeImplementationTest
{
    public class MirrorTreeTest
    {
        private string GetConsoleOutput(Action action)
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                action();
                return sw.ToString().Trim();
            }
        }

        private string ExtractTraversalOutput(string consoleOutput)
        {
            // Remove the prefix "In-Order Traversal:" and trim extra whitespace
            var lines = consoleOutput.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return lines.Length > 1 ? lines[1].Trim() : string.Empty;
        }

        [Fact]
        public void TestMirrorTreeAndInOrderTraversal()
        {
            // Arrange
            var bTree = new BinarySearchTree(4);
            bTree.Add(8);
            bTree.Add(7);
            bTree.Add(12);
            bTree.Add(9);

            // Act
            bTree.MirrorTree(bTree.Root);
            var inOrderOutput = GetConsoleOutput(bTree.PrintInOrder);
            var inOrderResult = ExtractTraversalOutput(inOrderOutput);

            // Assert
            var expectedInOrder = "12  9  8  7  4";
            Assert.Equal(expectedInOrder, inOrderResult);
        }

        [Fact]
        public void TestSingleNodeTree()
        {
            // Arrange
            var bTree = new BinarySearchTree(1);

            // Act
            bTree.MirrorTree(bTree.Root);
            var inOrderOutput = GetConsoleOutput(bTree.PrintInOrder);
            var inOrderResult = ExtractTraversalOutput(inOrderOutput);

            // Assert
            var expectedInOrder = "1";
            Assert.Equal(expectedInOrder, inOrderResult);
        }

        [Fact]
        public void TestEmptyTree()
        {
            // Arrange
            var bTree = new BinarySearchTree(0);
            bTree.Root = null; // Empty tree

            // Act
            bTree.MirrorTree(bTree.Root);
            var inOrderOutput = GetConsoleOutput(bTree.PrintInOrder);
            var inOrderResult = ExtractTraversalOutput(inOrderOutput);

            // Assert
            var expectedInOrder = ""; // Empty tree should have an empty traversal result
            Assert.Equal(expectedInOrder, inOrderResult);
        }
    }
}
