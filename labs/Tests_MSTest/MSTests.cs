using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_22_First_Test;

namespace Tests_MSTest
{
    [TestClass]
    public class MSTests
    {
        [TestMethod]
        public void SumTotalOfArray()
        {
            int[] myArray = { 10, 20, 30 };
            var expected = 3;
        }
    }
}
