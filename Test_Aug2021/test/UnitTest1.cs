using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test
{
    [TestClass]
    public class UnitTest1
    {
        private bool[] expected = {false, false, false, false, true, false, true, false, true, true, true};

        [TestMethod]
        public void TestModulo()
        {
            CollectionAssert.AreEqual(expected, new prod.Modulo().Run(11));
        }

        [TestMethod]
        public void TestModuloWithSquareRoot()
        {
            CollectionAssert.AreEqual(expected, new prod.ModuloWithSquareRoot().Run(11));
        }

        [TestMethod]
        public void TestSieve()
        {
            CollectionAssert.AreEqual(expected, new prod.Sieve().Run(11));
        }

        [TestMethod]
        public void TestSieveWithoutProduct()
        {
            CollectionAssert.AreEqual(expected, new prod.SieveWithoutProduct().Run(11));
        }

        [TestMethod]
        public void TestSieveImproved()
        {
            CollectionAssert.AreEqual(expected, new prod.SieveImproved().Run(11));
        }

        [TestMethod]
        public void TestSieveWithSquareRoot()
        {
            CollectionAssert.AreEqual(expected, new prod.SieveWithSquareRoot().Run(11));
        }
    }
}
