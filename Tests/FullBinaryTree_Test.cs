using Microsoft.VisualStudio.TestTools.UnitTesting;
using R.Stivens_Algoritms;

namespace Tests
{
    [TestClass]
    public class FullBinaryTree_Test
    {
        [TestMethod]
        public void AddValues_Test()
        {
            FullBinaryTree_v1 tree = new();
            tree.Add(0);
            tree.Add(1);
            tree.Add(2);
            tree.Add(3);
            tree.Add(4);
            tree.Add(5);
            tree.Add(6);
            tree.Add(7);
            tree.Add(8);

            Assert.AreEqual(0, tree.Root.Value);
            Assert.AreEqual(1, tree.Root.Left.Value);
            Assert.AreEqual(2, tree.Root.Right.Value);
            Assert.AreEqual(3, tree.Root.Left.Left.Value);
            Assert.AreEqual(4, tree.Root.Left.Right.Value);
            Assert.AreEqual(5, tree.Root.Right.Left.Value);
            Assert.AreEqual(6, tree.Root.Right.Right.Value);
            Assert.AreEqual(7, tree.Root.Left.Left.Left.Value);
            Assert.AreEqual(8, tree.Root.Left.Left.Right.Value);

            Assert.AreEqual(tree.Root, tree.Root.Left.Parent);
            Assert.AreEqual(tree.Root, tree.Root.Right.Parent);
            Assert.AreEqual(tree.Root.Left, tree.Root.Left.Left.Parent);
            Assert.AreEqual(tree.Root.Left, tree.Root.Left.Right.Parent);
            Assert.AreEqual(tree.Root.Right, tree.Root.Right.Left.Parent);
            Assert.AreEqual(tree.Root.Right, tree.Root.Right.Right.Parent);
        }
    }
}
