using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            double number1 = 1;
            double number2 = 5;

            double result = _calculatorEngine.Calculate(number1, number2, "add");
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            double number1 = 1;
            double number2 = 5;

            double result = _calculatorEngine.Calculate(number1, number2, "+");
            Assert.AreEqual(6, result);
        }
    }
}
