using Microsoft.VisualStudio.TestTools.UnitTesting;
using R.Stivens_Algoritms;
using System;

namespace Tests
{
    [TestClass]
    public class Array_Test
    {
        [TestMethod]
        public void TriangleArrayTest()
        {
            SymmetricTriangleArray triangleArray = new(3);
            triangleArray[0, 0] = 100;
            triangleArray[1, 1] = 102;
            triangleArray[2, 2] = 104;

            Assert.AreEqual(100, triangleArray[0, 0]);
            Assert.AreEqual(102, triangleArray[1, 1]);
            Assert.AreEqual(104, triangleArray[2, 2]);

            triangleArray[1, 0] = 302;
            Assert.AreEqual(302, triangleArray[0, 1]);

            triangleArray[2, 0] = 303;
            Assert.AreEqual(303, triangleArray[0, 2]);

            Assert.ThrowsException<ArgumentException>(() => triangleArray[3, 3]);
        }

        [TestMethod]
        public void BreakArrayTest()
        {
            BreakArray breakArray = new();
            breakArray.SetValue(0, 1, "NewValue");

            bool isFound = breakArray.TryGetValue(0, 1, out string expected);
            Assert.IsTrue(isFound);
            Assert.AreEqual(expected, "NewValue");

            isFound = breakArray.TryGetValue(1, 0, out string val);
            Assert.IsFalse(isFound);
            Assert.IsNull(val);
        }
    }
}
