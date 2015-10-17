using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator1;
using System.Collections.Generic;

namespace SimpleCalculatorTest_1
{
    [TestClass]
    public class ParseTest
    {

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestOnlyOneOperatorAlllowedInInput()
        {
            Parse parse = new Parse();
            parse.ReadInput("1++1");
        }


        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestOnlyOneNumberInInput()
        {
            Parse parse = new Parse();
            parse.ReadInput("1+");
        }


        [TestMethod]
        public void TestValidInput()
        {
            Parse myInput = new Parse();
            myInput.ReadInput("1+2");
            Assert.AreEqual(1, myInput.Value1);
            Assert.AreEqual(2, myInput.Value2);
            Assert.AreEqual('+', myInput.Operador);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestNoOperatorInInput()
        {
            Parse parse = new Parse();
            parse.ReadInput("11");
        }
    }
}
