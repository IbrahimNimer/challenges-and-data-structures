using System;
using System.IO;
using Xunit;
using Linked_List_Implementation; 

namespace LinkedListTests
{
    public class LinkedListTests
    {
        [Fact]
        public void Remove_Node()
        {
            // Arrange
            var list = new Linked_List_Implementation.Program.LinkedList();
            list.Add(10);
            list.Add(20);
            list.Add(30);

            // Act
            list.Remove(30);

            // Assert
            Assert.False(list.Includes(30));
        }

        [Fact]
        public void PrintListContent()
        {
            // Arrange
            var list = new Linked_List_Implementation.Program.LinkedList();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            var expectedOutput = "Head -> 10 -> 20 -> 30 -> Null" + Environment.NewLine;

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                list.PrintList();

                // Assert
                var result = sw.ToString();
                Assert.Equal(expectedOutput, result);
            }
        }
    }
}
