using Microsoft.VisualStudio.TestTools.UnitTesting;
using unit_testing_using_mstest;

namespace unit_testing_using_mstest.Tests
{
    [TestClass]
    public class PrimeService_IsPrimeShould
    {
        /*
        [TestMethod]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(1);

            Assert.IsFalse(result, "1 should not be prime");
        }
        */

        [DataTestMethod]    // Allows you to test multiple inputs in one unit test
        [DataRow(-1)]   
        [DataRow(0)]
        [DataRow(1)]

        [TestMethod]
        public void IsPrime_InputIs1_ReturnFalse(int value)
        {
            var primeService = new PrimeService();
            var result = primeService.IsPrime(value);

            Assert.IsFalse(result, $"{value} should not be prime");
        }



    }
}
