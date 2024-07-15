using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_Implementation_Test
{
    public class UnitTest2
    {

        [Fact]
        public void RemoveDuplicate_NoDuplicates()
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
                list.RemoveDuplicate();
                list.PrintList();

                // Assert
                var result = sw.ToString();
                Assert.Equal(expectedOutput, result);
            }
        }

        [Fact]
        public void RemoveDuplicate_RemovesOnlyDuplicates()
        {
            // Arrange
            var list = new Linked_List_Implementation.Program.LinkedList();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(20);  // Duplicate
            list.Add(10);  // Duplicate
            var expectedOutput = "Head -> 10 -> 20 -> 30 -> Null" + Environment.NewLine;

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                list.RemoveDuplicate();
                list.PrintList();

                // Assert
                var result = sw.ToString();
                Assert.Equal(expectedOutput, result);
            }
        }

        [Fact]
        public void RemoveDuplicate_AllNodesDuplicates()
        {
            // Arrange
            var list = new Linked_List_Implementation.Program.LinkedList();
            list.Add(10);
            list.Add(10);
            list.Add(10);
            list.Add(10);
            var expectedOutput = "Head -> 10 -> Null" + Environment.NewLine;

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                list.RemoveDuplicate();
                list.PrintList();

                // Assert
                var result = sw.ToString();
                Assert.Equal(expectedOutput, result);
            }
        }
    }
}
