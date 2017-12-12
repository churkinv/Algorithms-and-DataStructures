using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Tests
{
    [TestClass()]
    public class LinkedListTests
    {
        [TestMethod()]
        public void RemoveFirstTest()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            LinkedListNode<int> linkedListNodeFirst = new LinkedListNode<int>(1);
            //LinkedListNode<int> linkedListNodeSecond = new LinkedListNode<int>(2);

            //linkedListNodeFirst.Next = linkedListNodeSecond;
            //linkedList.AddFirst(linkedListNodeSecond);
            linkedList.AddFirst(linkedListNodeFirst);            

            linkedList.RemoveFirst();

            var actual = linkedList.Count;
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }
    }
}