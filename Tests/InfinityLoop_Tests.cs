using Microsoft.VisualStudio.TestTools.UnitTesting;
using R.Stivens_Algoritms;

namespace Tests
{
    [TestClass]
    public class InfinityLoop_Tests
    {
        readonly LinkedNode loopNode;
        readonly LinkedNode unloopNode;
        readonly LinkedNode loopNodeThroughtCenter;

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

            loopNodeThroughtCenter = InitializeLoopNodeFromCenter();
        }

        private static LinkedNode InitializeLoopNodeFromCenter()
        {
            LinkedNode result = new()
            {
                Next = new()
            };

            LinkedNode loopHere = new();
            loopHere.Next = new()
            {
                Next = new()
                {
                    Next = new()
                    {
                        Next = new()
                        {
                            Next = loopHere
                        }
                    }
                }
            };

            result.Next.Next = loopHere;
            return result;
        }

        [TestMethod]
        public void IsLooped_Test()
        {
            Assert.IsTrue(LinkedNode.HasLoopUsingHashTable(loopNode));
            Assert.IsTrue(LinkedNode.HasLoopUsingHashTable(loopNodeThroughtCenter));
            Assert.IsFalse(LinkedNode.HasLoopUsingHashTable(unloopNode));
        }

        [TestMethod]
        public void IsLoopedTracing_Test()
        {
            Assert.IsTrue(LinkedNode.HasLoopUsingTracing(loopNodeThroughtCenter));
            Assert.IsTrue(LinkedNode.HasLoopUsingTracing(loopNode));
            Assert.IsFalse(LinkedNode.HasLoopUsingTracing(unloopNode));
        }

        [TestMethod]
        public void IsLoopedTortoiseAndRabbit()
        {
            Assert.IsTrue(LinkedNode.HasLoopUsingRabbitAndTortoiseAlgorithm(loopNode));
            Assert.IsTrue(LinkedNode.HasLoopUsingRabbitAndTortoiseAlgorithm(loopNodeThroughtCenter));
            Assert.IsFalse(LinkedNode.HasLoopUsingRabbitAndTortoiseAlgorithm(unloopNode));
        }
    }
}
