using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Linked_List_Implementation.Program;

namespace Linked_List_Implementation_Test
{
    public class RotTest
    {
        [Fact]
        public void RotateByZero_ShouldRemainUnchanged()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            // Act
            LinkedList rotatedList = LinkedList.RotateLinkedList(list, 0);

            // Assert
            Assert.Equal("Head -> 1 -> 2 -> 3 -> 4 -> 5 -> Null", rotatedList.ToString());
        }

        [Fact]
        public void RotateByGreaterThanLength_ShouldNormalizeAndRotate()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            // Act
            LinkedList rotatedList = LinkedList.RotateLinkedList(list, 7); 

            // Assert
            Assert.Equal("Head -> 3 -> 4 -> 5 -> 1 -> 2 -> Null", rotatedList.ToString());
            
        }
    }
}
