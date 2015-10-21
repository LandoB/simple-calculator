using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCalculator1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculatorTest1
{
    class StackTest
    {
        [TestMethod]
        public void TestStackGetAndSetAnswer()
        {
            int answer = 1;
            Stack.PutAnswerOnStack(answer.ToString());
            Assert.AreEqual(1, Stack.GetAnswerFromStack());
        }

        [TestMethod]
        public void TestStackGetAndSetExpression()
        {
            Stack.PutInputOnStack("8 * 1");
            Assert.AreEqual("8 * 1", Stack.GetInputFromStack());
        }
    }
}
