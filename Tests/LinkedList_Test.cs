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
    }
}
