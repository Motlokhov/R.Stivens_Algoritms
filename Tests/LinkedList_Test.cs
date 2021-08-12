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
            sut.AddAfter(0, 3);
            sut.AddAfter(3, 8);
        }

        [TestMethod]
        public void FindHeadTest()
        {
            LinkedListNode head = sut.Find(0);
            Assert.AreSame(null, head.Preveous);
            Assert.AreEqual(0, head.Value);
            Assert.AreEqual(3, head.Next.Value);
        }

        [TestMethod]
        public void FindValueTest()
        {
            LinkedListNode node = sut.Find(3);
            Assert.AreEqual(3, node.Value);
            Assert.AreEqual(8, node.Next.Value);
            Assert.AreEqual(0, node.Preveous.Value);
        }
        [TestMethod]
        public void FindTailTest()
        {
            LinkedListNode tail = sut.FindFrom(sut.Find(0),0);
            Assert.AreEqual(0, tail.Value);
            Assert.AreEqual(8, tail.Preveous.Value);
            Assert.AreEqual(null, tail.Next);
        }

        [TestMethod]
        public void ActionIterateTest()
        {
            LinkedList.ActionIterate((value) => Trace.Write($"Value:{value} {Environment.NewLine}"), sut.Find(0));
        }

        [TestMethod]
        public void AddAtEndTest()
        {
            sut.AddAtEnd(3);
            LinkedListNode node = sut.Find(0);

            Assert.AreEqual(3, node.Next.Value);
        }

        [TestMethod]
        public void AddAfterTest()
        {
            sut.AddAfter(0,3);
            LinkedListNode node = sut.Find(0);

            Assert.AreEqual(3, node.Next.Value);
        }
    }
}
