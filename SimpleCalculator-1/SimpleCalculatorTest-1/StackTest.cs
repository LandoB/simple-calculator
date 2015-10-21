using System;
using SimpleCalculator1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculatorTest1
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void TestEnteredKeywordLast()
        {
            string myKeyword = "last";
            Stack.RunKeywordEvaluation(myKeyword);
            Assert.AreEqual("last", Stack.RunKeywordEvaluation(myKeyword));
        }

        [TestMethod]
        public void TestEnteredKeywordLastQ()
        {
            string myKeyword = "lastq";
            Stack.RunKeywordEvaluation(myKeyword);
            Assert.AreEqual("lastq", Stack.RunKeywordEvaluation(myKeyword));
        }

        [TestMethod]
        public void TestStackGetAndSetAnswer()
        {
            int answer = 1;
            Stack.PutAnswerOnStack(answer.ToString());
            Assert.AreEqual("1", Stack.GetAnswerFromStack());
        }

        [TestMethod]
        public void TestStackGetAndSetInput()
        {
            Stack.PutInputOnStack("5 * 1");
            Assert.AreEqual("5 * 1", Stack.GetInputFromStack());
        }

        
    }
}
