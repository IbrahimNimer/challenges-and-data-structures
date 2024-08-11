using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementationTest
{
    public class BinarySearchTreeTest
    {
        [Fact]
        public void TestAddingANode()
        {
            // Arrange
            var bst = new BinarySearchTree(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(3);
            bst.Add(7);

            var expectedOutput = "10  5  3  7  15";
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            bst.PrintPreOrder();

            // Assert
            var actualOutput = stringWriter.ToString().Trim();

            // Remove header "Pre-Order Traversal:"
            var cleanOutput = actualOutput.Replace("Pre-Order Traversal:", "").Trim();

            Assert.Equal(expectedOutput, cleanOutput);
        }



        [Fact]
        public void TestCheckingIfANodeExists()
        {
            // Arrange
            var bst = new BinarySearchTree(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(3);
            bst.Add(7);

            // Act & Assert
            Assert.True(bst.Contains(7));
            Assert.False(bst.Contains(20));
        }

        [Fact]
        public void TestRemovingANode()
        {
            // Arrange
            var bst = new BinarySearchTree(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(3);
            bst.Add(7);
            bst.Add(12);
            bst.Add(18);

            // Act
            bst.Remove(7);
            bst.Remove(15);

            var expectedOutput = "10  5  3  18  12";
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            bst.PrintPreOrder();

            // Assert
            var actualOutput = stringWriter.ToString().Trim();

            // Remove header "Pre-Order Traversal:"
            var cleanOutput = actualOutput.Replace("Pre-Order Traversal:", "").Trim();

            Assert.Equal(expectedOutput, cleanOutput);
        }
    }
}
