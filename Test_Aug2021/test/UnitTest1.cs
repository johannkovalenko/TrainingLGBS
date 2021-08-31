using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] expected = {3, 4, 7, 8 };
            int[] actual = {3, 4, 7, 8 };

            CollectionAssert.AreEqual(expected, actual);

        }
    }
}
