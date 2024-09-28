using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementationTest
{
    public class RightViewTest
    {
        private void CaptureConsoleOutput(Action action, out string output)
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                action.Invoke();
                output = sw.ToString();
            }
        }

        [Fact]
        public void Test_RightView_CorrectOutput()
        {
            // Arrange
            var bTree = new BinaryTree(2);
            bTree.Root.Left = new Node(3);
            bTree.Root.Right = new Node(5);
            bTree.Root.Left.Left = new Node(4);
            bTree.Root.Right.Right = new Node(6);
            bTree.Root.Left.Left.Right = new Node(7);

            // Act
            CaptureConsoleOutput(() => bTree.PrintRightView(), out string output);

            // Assert
            Assert.Equal($"2{Environment.NewLine}5{Environment.NewLine}6{Environment.NewLine}7{Environment.NewLine}", output);
        }

        [Fact]
        public void Test_RightView_OnlyRightNodes()
        {
            // Arrange
            var bTree = new BinaryTree(1);
            bTree.Root.Right = new Node(2);
            bTree.Root.Right.Right = new Node(3);
            bTree.Root.Right.Right.Right = new Node(4);

            // Act
            CaptureConsoleOutput(() => bTree.PrintRightView(), out string output);

            // Assert
            Assert.Equal($"1{Environment.NewLine}2{Environment.NewLine}3{Environment.NewLine}4{Environment.NewLine}", output);
        }

    }
    
}
