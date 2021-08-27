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
    public class InfinityLoop_Tests
    {
        readonly LinkedNode loopNode;
        readonly LinkedNode unloopNode;

        public InfinityLoop_Tests()
        {
            loopNode = new LinkedNode
            {
                Next = new LinkedNode()
            };

            loopNode.Next.Next = loopNode;

            unloopNode = new LinkedNode()
            {
                Next = new LinkedNode()
            };
        }

        [TestMethod]
        public void IsLooped_Test()
        {
            Assert.IsTrue(LinkedNode.HasLoopUsingHashTable(loopNode));
            Assert.IsFalse(LinkedNode.HasLoopUsingHashTable(unloopNode));
        }
    }
}
