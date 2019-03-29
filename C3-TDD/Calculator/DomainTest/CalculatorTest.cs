using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace DomainTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void MakeSumTest()
        {
            Calculator calculator = new Calculator();

            Assert.AreEqual(4, calculator.Sum(2, 2));
            Assert.AreEqual(6, calculator.Sum(3, 3));
        }

        [TestMethod]
        public void MakeDivisionTest()
        {
            Calculator calculator = new Calculator();

            Assert.AreEqual(4, calculator.Divide(8, 2));
        }

        [TestMethod]
        [ExpectedException(typeof(CannotDivideByZeroException))]
        public void MakeDivisionByZeroTest()
        {
            Calculator calculator = new Calculator();

            calculator.Divide(3, 0);
        }

        [TestMethod]
        public void MakeMultiplicationTest()
        {
            Calculator calculator = new Calculator();

            Assert.AreEqual(0, calculator.Multiply(2, 0));
            Assert.AreEqual(6, calculator.Multiply(2, 3));
        }

        [TestMethod]
        public void MakeSubstractionTest()
        {
            Calculator calculator = new Calculator();

            Assert.AreEqual(-2, calculator.Substract(2, 4));
            Assert.AreEqual(0, calculator.Substract(3, 3));
            Assert.AreEqual(2, calculator.Substract(4, 2));
        }

        [TestMethod]
        public void SumByTest()
        {
            Calculator calculator = new Calculator(2);

            Assert.AreEqual(5, calculator.SumBy(3).Result);
        }

        [TestMethod]
        public void MultiplyByTest()
        {
            Calculator calculator = new Calculator(1);

            int actualResult = calculator.MultiplyBy(2).MultiplyBy(3).Result;

            Assert.AreEqual(6, actualResult);
        }

        [TestMethod]
        public void DivideByTest()
        {
            Calculator calculator = new Calculator(8);

            int actualResult = calculator.DivideBy(2).DivideBy(4).Result;

            Assert.AreEqual(1, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(CannotDivideByZeroException))]
        public void DivideByWithZeroTest()
        {
            Calculator calculator = new Calculator(8);

            calculator.DivideBy(2).DivideBy(0).DivideBy(4);
        }

        [TestMethod]
        public void SubstractByTest()
        {
            Calculator calculator = new Calculator(10);

            int actualResult = calculator.SubstractBy(2).SubstractBy(10).Result;

            Assert.AreEqual(-2, actualResult);
        }

        [TestMethod]
        public void ChainOperandsTest()
        {
            Calculator calculator = new Calculator(0);

            int actualResult = calculator.SumBy(6).SumBy(4).MultiplyBy(2).SubstractBy(5).DivideBy(3).Result;

            Assert.AreEqual(5, actualResult);
        }
    }
}
