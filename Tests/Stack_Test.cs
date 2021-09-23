using Microsoft.VisualStudio.TestTools.UnitTesting;
using R.Stivens_Algoritms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    public class Stack_Test
    {
        [TestMethod]
        public void DoubleStack_Test()
        {
            DoubleStack doubleStack = new(3);
            doubleStack.PushLeft("left 1");
            doubleStack.PushLeft("left 2");
            doubleStack.PushLeft("middle");

            Assert.ThrowsException<ArgumentException>(() => { doubleStack.PushLeft("exception"); });

            Assert.AreEqual("middle", doubleStack.PopLeft());
            Assert.AreEqual("left 2", doubleStack.PopLeft());
            Assert.AreEqual("left 1", doubleStack.PopLeft());
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Assert.AreEqual("exception", doubleStack.PopLeft());
            });

            doubleStack.PushRight("right 1");
            doubleStack.PushRight("right 2");
            doubleStack.PushRight("middle");

            Assert.ThrowsException<ArgumentException>(() => { doubleStack.PushLeft("exception"); });

            Assert.AreEqual("middle", doubleStack.PopRight());
            Assert.AreEqual("right 2", doubleStack.PopRight());
            Assert.AreEqual("right 1", doubleStack.PopRight());
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Assert.AreEqual("exception", doubleStack.PopRight());
            });
        }

        [TestMethod]
        public void ReverceArrayWithStack_Test()
        {
            char[] word = new char[] { 'w', 'o', 'r', 'd' };
            char[] result = ReverceArrayWithStack.Do(word);

            CollectionAssert.AreEqual(new char[4] { 'd', 'r', 'o', 'w' }, result);
        }
    }
}
