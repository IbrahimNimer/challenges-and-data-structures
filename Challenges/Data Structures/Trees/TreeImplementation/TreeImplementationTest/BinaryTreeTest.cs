using TreeImplementation;

namespace TreeImplementationTest
{
    public class BinaryTreeTest
    {
          [Fact]
  public void Test1()
  {
      BinaryTree Btree2 = new BinaryTree(10);
      Btree2.Root.Left = new Node(5);
      Btree2.Root.Right = new Node(20);
      Btree2.Root.Left.Left = new Node(3);
      Btree2.Root.Left.Right = new Node(7);
      Btree2.Root.Right.Left = new Node(15);
      Btree2.Root.Right.Right = new Node(25);
      int expected = 20;
      int secondMax = Btree2.FindSecondMax(Btree2.Root); // Output: 20
      Assert.Equal(expected, secondMax);
  }
  [Fact]
  public void TestUnique()
  {
      BinaryTree Btree2 = new BinaryTree(10);
      int expected = 10;
      int secondMax = Btree2.FindSecondMax(Btree2.Root); // Output: 20
      Assert.Equal(expected, secondMax);
  }
  [Fact]
  public void TestNegative()
  {
      BinaryTree Btree1 = new BinaryTree(10);
      Btree1.Root.Left = new Node(5);
      Btree1.Root.Right = new Node(20);
      Btree1.Root.Left.Left = new Node(-3);
      Btree1.Root.Left.Right = new Node(7);
      Btree1.Root.Right.Left = new Node(15);
      Btree1.Root.Right.Right = new Node(25);
      int expected = 20;
      int secondMax = Btree1.FindSecondMax(Btree1.Root); // Output: 20
      Assert.Equal(expected, secondMax);
  }
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
