using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator1;

namespace SimpleCalculatorTest1
{
    [TestClass]
    public class EvaluateTest
    {

        [TestMethod]
        public void TestValidateInputAdd()
        {
            Evaluate myCalc = new Evaluate();
            myCalc.RunEvaluation(7, 3, '+');
            Assert.AreEqual(10, myCalc.Resultado);
        }

        [TestMethod]
        public void TestValidateInputSubtract()
        {
            Evaluate myCalc = new Evaluate();
            myCalc.RunEvaluation(7, 3, '-');
            Assert.AreEqual(4, myCalc.Resultado);
        }

        [TestMethod]
        public void TestValidateInputMultiply()
        {
            Evaluate myCalc = new Evaluate();
            myCalc.RunEvaluation(7, 3, '*');
            Assert.AreEqual(21, myCalc.Resultado);
        }

        [TestMethod]
        public void TestValidateInputDivide()
        {
            Evaluate myCalc = new Evaluate();
            myCalc.RunEvaluation(9, 3, '/');
            Assert.AreEqual(3, myCalc.Resultado);
        }

        [TestMethod]
        public void TestValidateInputModulus()
        {
            Evaluate myCalc = new Evaluate();
            myCalc.RunEvaluation(8, 4, '%');
            Assert.AreEqual(0, myCalc.Resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestInvalidExpression()
        {
            Evaluate myCalc = new Evaluate();
            myCalc.RunEvaluation(9, 3, '&');

        }
    }
}
