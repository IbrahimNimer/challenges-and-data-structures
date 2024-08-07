using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StackAndQueue_Test
{
    public class MinStackTest
    {

        [Fact]
        public void RetrievingMinElement()
        {

            //Arrange
            StackAndQueue.MinStack.MinStackClass minStack = new StackAndQueue.MinStack.MinStackClass();
            minStack.Push(8);
            minStack.Push(5);
            minStack.Push(2);
            minStack.Push(11);
            minStack.Push(3);

            //Act
            int minElement = minStack.GetMin();


            //Assert

            Assert.Equal(2, minElement);

        }



        //Test popping elements and verifying the minimum element in the stack after the pop.
        [Fact]
        public void PopElement_VerifyingMinElement()
        {

            //Arrange
            StackAndQueue.MinStack.MinStackClass minStack = new StackAndQueue.MinStack.MinStackClass();
            minStack.Push(8);
            minStack.Push(5);
            minStack.Push(4);
            minStack.Push(11);
            minStack.Push(3);
            minStack.Pop();

            //Act
            int minElement = minStack.GetMin();


            //Assert
            Assert.Equal(4, minElement);


        }


        //Test pushing elements and verifying the minimum element in the stack after the push.
        [Fact]
        public void PushElement_VerifyingMinElement()
        {

            //Arrange
            StackAndQueue.MinStack.MinStackClass minStack = new StackAndQueue.MinStack.MinStackClass();
            minStack.Push(8);
            minStack.Push(5);
            minStack.Push(4);
            minStack.Push(11);
            minStack.Push(3);
            minStack.Pop();
            minStack.Push(1);

            //Act
            int minElement = minStack.GetMin();


            //Assert
            Assert.Equal(1, minElement);


        }
    }
}
