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
        public void TestSetConstants()
        {
            Calculate myCalc = new Calculate();
            myCalc.Constants = new Dictionary<char, int>();
            myCalc.Constants.Add('x', 3);
            Assert.AreEqual(3, myCalc.Constants['x']);
        }
    }
}
