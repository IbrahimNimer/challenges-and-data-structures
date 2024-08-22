using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementationTest
{
    public class LeafSumTest
    {


        [Fact]
        public void TestLeafSum()
        {
            // Arrange
            var bTree = new BinaryTree(9);
            bTree.Root.Left = new Node(8);
            bTree.Root.Right = new Node(12);
            bTree.Root.Left.Left = new Node(3);
            bTree.Root.Left.Right = new Node(7);
            bTree.Root.Right.Left = new Node(17);
            bTree.Root.Right.Right = new Node(23);
            bTree.Root.Left.Left.Right = new Node(4);

            // Act
            int result = bTree.LeafSum(bTree.Root);


            // Assert

            Assert.Equal(result, 51);
        }


        [Fact]
        public void TestNegativeLeafSum()
        {
            // Arrange
            var bTree = new BinaryTree(-9);
            bTree.Root.Left = new Node(-8);
            bTree.Root.Right = new Node(-12);
            bTree.Root.Left.Left = new Node(-3);
            bTree.Root.Left.Right = new Node(-7);
            bTree.Root.Right.Left = new Node(-17);
            bTree.Root.Right.Right = new Node(-23);
            bTree.Root.Left.Left.Right = new Node(-4);

            // Act
            int result = bTree.LeafSum(bTree.Root);


            // Assert

            Assert.Equal(result, -51);
        }

    }
}
