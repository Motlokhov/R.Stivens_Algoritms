using Microsoft.VisualStudio.TestTools.UnitTesting;
using R.Stivens_Algoritms;
using System;
using System.Diagnostics;
using static R.Stivens_Algoritms.LinkedList;

namespace Tests
{
    [TestClass]
    public class LinkedList_Test
    {
        readonly LinkedList sut = new();

        public LinkedList_Test()
        {
            sut.AddFirst(0);
            sut.AddAfter(0, 3);
            sut.AddAfter(3, 8);
        }

        [TestMethod]
        public void FindHeadTest()
        {
            LinkedListNode head = sut.Find(0);
            Assert.AreSame(null, head.Previous);
            Assert.AreEqual(0, head.Value);
            Assert.AreEqual(3, head.Next.Value);
        }

        [TestMethod]
        public void FindValueTest()
        {
            LinkedListNode node = sut.Find(3);
            Assert.AreEqual(3, node.Value);
            Assert.AreEqual(8, node.Next.Value);
            Assert.AreEqual(0, node.Previous.Value);
        }
        [TestMethod]
        public void FindTailTest()
        {
            LinkedListNode tail = sut.Find(8);
            Assert.AreEqual(8, tail.Value);
            Assert.AreEqual(3, tail.Previous.Value);
            Assert.AreSame(null, tail.Next);
        }

        [TestMethod]
        public void FindBeforeTest()
        {
            Assert.AreEqual(3, sut.FindBefore(8).Value);
        }

        [TestMethod]
        public void AddAtTopTest()
        {
            sut.AddFirst(10);
            LinkedListNode node = sut.Find(10);
            Assert.AreEqual(10, node.Value);
            Assert.AreEqual(0, node.Next.Value);
            Assert.AreEqual(null, node.Previous);
        }

        [TestMethod]
        public void AddAtEndTest()
        {
            sut.AddLast(20);
            LinkedListNode node = sut.Find(20);
            Assert.AreEqual(20, node.Value);
            Assert.AreEqual(8, node.Previous.Value);
            Assert.AreEqual(null, node.Next);
        }

        [TestMethod]
        public void AddBeforeTest()
        {
            sut.AddBefore(8,30);
            LinkedListNode node = sut.Find(30);

            Assert.AreEqual(30, node.Value);
            Assert.AreEqual(8, node.Next.Value);
            Assert.AreEqual(3, node.Previous.Value);
        }

        [TestMethod]
        public void CopyTest()
        {
            LinkedList ll = new LinkedList();
            sut.Copy(ll);
            LinkedListNode index0 = sut.Find(0);
            LinkedListNode index1 = sut.Find(3);
            LinkedListNode index2 = sut.Find(8);

            Assert.IsTrue(index0._previous.Equals(index2));
            Assert.IsTrue(index0.Equals(index1.Previous));
            Assert.IsTrue(index0.Next.Equals(index1));
            Assert.IsTrue(index1.Equals(index2.Previous));
            Assert.IsTrue(index1.Next.Equals(index2));
            Assert.IsTrue(index2._next.Equals(index0));
        }

        [TestMethod]
        public void InsertSortTest()
        {
            sut.AddFirst(10);
            sut.AddFirst(3);

            LinkedList sorted = new();
            sut.InsertionSortIn(sorted);

            LinkedListNode first = sorted.Find(0);
            Assert.AreEqual(null, first.Previous);
            Assert.AreEqual(0, first.Value);
            Assert.AreEqual(3, first.Next.Value);
            Assert.AreEqual(3, first.Next.Next.Value);
            Assert.AreEqual(8, first.Next.Next.Next.Value);

            LinkedListNode last = first.Next.Next.Next.Next;
            
            Assert.AreEqual(null,last.Next);
            Assert.AreEqual(10, last.Value);
            Assert.AreEqual(8, last.Previous.Value);
            Assert.AreEqual(3, last.Previous.Previous.Value);
            Assert.AreEqual(3, last.Previous.Previous.Previous.Value);
            Assert.AreEqual(0, last.Previous.Previous.Previous.Previous.Value);

            Assert.AreEqual(last._next, first);
            Assert.AreEqual(first._previous, last);
        }
    }
}
