using System;
using Xunit;
using static Linked_List_Implementation.Program;

namespace Linked_List_Implementation_Test
{
    public class UnitTest3
    {
        [Fact]
        public void TestMergingWhenOneListIsEmpty()
        {
            // Arrange
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            list1.Add(10);
            list1.Add(20);
            list1.Add(30);

            // Act
            LinkedList mergedList = LinkedList.MergeSortedLists(list1, list2);

            // Assert
            Assert.Equal("Head -> 10 -> 20 -> 30 -> Null", mergedList.ToString());
        }

        [Fact]
        public void TestMergingWhenBothListsAreEmpty()
        {
            // Arrange
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();

            // Act
            LinkedList mergedList = LinkedList.MergeSortedLists(list1, list2);

            // Assert
            Assert.Equal("Head -> Null", mergedList.ToString());
        }

        [Fact]
        public void TestMergingList1AndList2()
        {
            // Arrange
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();

            list1.Add(2);
            list1.Add(5);
            list1.Add(10);
            list2.Add(3);
            list2.Add(15);
            list2.Add(20);

            // Act
            LinkedList mergedList = LinkedList.MergeSortedLists(list1, list2);

            // Assert
            Assert.Equal("Head -> 2 -> 3 -> 5 -> 10 -> 15 -> 20 -> Null", mergedList.ToString());
        }
    }
}
