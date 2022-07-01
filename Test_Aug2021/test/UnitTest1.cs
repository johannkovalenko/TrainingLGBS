using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace test
{
    [TestClass]
    public class UnitTest1
    {
        private List<int> expected = new List<int> {2, 3, 5, 7};

        [TestMethod]
        public void TestModulo()
        {
            var algorithm = new prod.Modulo();
            algorithm.Run(11);

            CollectionAssert.AreEqual(expected, algorithm.GetPrimeNumbers());
        }

        [TestMethod]
        public void TestModuloWithSquareRoot()
        {
            var algorithm = new prod.ModuloWithSquareRoot();
            algorithm.Run(11);

            CollectionAssert.AreEqual(expected, algorithm.GetPrimeNumbers());
        }

        [TestMethod]
        public void TestSieve()
        {
            var algorithm = new prod.Sieve();
            algorithm.Run(11);

            CollectionAssert.AreEqual(expected, algorithm.GetPrimeNumbers());
        }

        [TestMethod]
        public void TestSieveWithoutProduct()
        {
            var algorithm = new prod.SieveWithoutProduct();
            algorithm.Run(11);

            CollectionAssert.AreEqual(expected, algorithm.GetPrimeNumbers());
        }

        [TestMethod]
        public void TestSieveImproved()
        {
            var algorithm = new prod.SieveImproved();
            algorithm.Run(11);

            CollectionAssert.AreEqual(expected, algorithm.GetPrimeNumbers());
        }

        [TestMethod]
        public void TestSieveWithSquareRoot()
        {
            var algorithm = new prod.SieveWithSquareRoot();
            algorithm.Run(11);

            CollectionAssert.AreEqual(expected, algorithm.GetPrimeNumbers());
        }
    }
}
