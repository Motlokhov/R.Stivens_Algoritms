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
            sut.AddAtTop(2);
            sut.AddAtTop(1);
        }

        [TestMethod]
        public void FindItemsTest()
        {
            Assert.AreEqual(1, sut.Find(1).Value);
            Assert.AreEqual(0, sut.Find(0).Value);
            Assert.IsNull(sut.Find(-1));
        }

        [TestMethod]
        public void ActionIterateTest()
        {
            sut.ActionIterate((value) => Trace.Write($"Value:{value} {Environment.NewLine}"));
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
