using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class SumTest
    {
        [TestMethod]
        public void Test_Sum_ReturnCorrect()
        {
            int num1 = 2;
            int num2 = 3;

            int eSum = 5;
            int aSum = num1 + num2;

            Assert.AreEqual(eSum, aSum);
        }

        [TestMethod]
        public void Test_Sum_ReturnIncorrect()
        {
            int num1 = 2;
            int num2 = 3;

            int eSum = 5;
            int aSum = num1 + num2 + 1;

            Assert.AreNotEqual(eSum, aSum);
        }

        [TestMethod]
        public void Test_SumMethod_ReturnCorrect()
        {
            int num1 = 2;
            int num2 = 3;

            int eSum = 5;
            int aSum = CalculateService.Sum(num1, num2);

            Assert.AreEqual(eSum, aSum);
        }

        [TestMethod]
        public void Test_SumMethod_ReturnIncorrect()
        {
            int num1 = 2;
            int num2 = 3;

            int eSum = 5;
            int aSum = CalculateService.Sum(num1, num1);

            Assert.AreNotEqual(eSum, aSum);
        }
    }
}
