using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;
using System.Collections.Generic;

namespace UnitTestSimpleCalculator
{
    [TestClass]
    public class UnitTestCalculator
    {
        [TestMethod]
        public void TestCounter()
        {
            Calculate myCalc = new Calculate();
            Assert.AreEqual(0, myCalc.GetCounter());
        }

        [TestMethod]
        public void TestSetInputs()
        {
            Calculate myCalc = new Calculate();
            myCalc.Inputs = new List<string>();
            myCalc.Inputs.Add("1+1");
            Assert.AreEqual(true, myCalc.Inputs.Contains("1+1"));
        }

        [TestMethod]
        public void TestValidateInputAdd()
        {
            Calculate myCalc = new Calculate();
            string input = "7 + 2";
            Assert.AreEqual(Calculate.Action.ADD, myCalc.ValidateInput(input));
        }

        [TestMethod]
        public void TestValidateInputSubtract()
        {
            Calculate myCalc = new Calculate();
            string input = "7 - 2";
            Assert.AreEqual(Calculate.Action.SUBTRACT, myCalc.ValidateInput(input));
        }

        [TestMethod]
        public void TestValidateInputMultiply()
        {
            Calculate myCalc = new Calculate();
            string input = "7 * 2";
            Assert.AreEqual(Calculate.Action.MULTIPLY, myCalc.ValidateInput(input));
        }

        [TestMethod]
        public void TestValidateInputDivide()
        {
            Calculate myCalc = new Calculate();
            string input = "8 / 2";
            Assert.AreEqual(Calculate.Action.DIVIDE, myCalc.ValidateInput(input));
        }

        [TestMethod]
        public void TestValidateInputModulus()
        {
            Calculate myCalc = new Calculate();
            string input = "7 % 2";
            Assert.AreEqual(Calculate.Action.MODULUS, myCalc.ValidateInput(input));
        }

        [TestMethod]
        public void TestValidateInputExit()
        {
            Calculate myCalc = new Calculate();
            string input = "   exit ";
            Assert.AreEqual(Calculate.Action.EXIT, myCalc.ValidateInput(input));
        }

        [TestMethod]
        public void TestValidateInputBye()
        {
            Calculate myCalc = new Calculate();
            string input = "quit ";
            Assert.AreEqual(Calculate.Action.EXIT, myCalc.ValidateInput(input));
        }
    }
}
