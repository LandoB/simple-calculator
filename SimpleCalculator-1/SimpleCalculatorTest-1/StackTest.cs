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
            Stack myKeyword = StackSingleton.Instance;
            Evaluate myExpression = new Evaluate();
            myExpression.RunOperation(1, 1, '+');
            Assert.AreEqual("2", myKeyword.RunKeywordEvaluation("last"));
        }

        [TestMethod]
        public void TestEnteredKeywordLastQ()
        {
            Stack myKeyword = StackSingleton.Instance;
            Evaluate myExpression = new Evaluate();
            myExpression.RunOperation(2, 2, '+');
            Assert.AreEqual("2+2", myKeyword.RunKeywordEvaluation("lastq"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNotTheRightKeyword()
        {
            Stack myKeyword = StackSingleton.Instance;
            string myWord = "  lasst";
            myKeyword.RunKeywordEvaluation(myWord);
        }

        // Chunk 4 - Constants


        [TestMethod]
        public void TestAddingConstantToDictionary()
        {
            Stack myConstant = StackSingleton.Instance;
            string addedConstant = "a";
            myConstant.AddConstantToDictionary("a", 1);
            Assert.AreEqual("a", addedConstant);
        }

        [TestMethod]
        public void TestConstantIsInDictionary()
        {
            Stack myConstant = StackSingleton.Instance;
            string key = "a";
            myConstant.ConstantIsInDictionary("a");
            Assert.AreEqual(false, myConstant.ConstantIsInDictionary(key));
        }

        [TestMethod]
        public void TestGettingValueOfConstantFromDictionary()
        {
            Stack myConstant = StackSingleton.Instance;
            string key = "a";
            int value = 1;
            myConstant.AddConstantToDictionary(key, value);
            Assert.AreEqual(value, myConstant.ReturnConstantValue(key));
        }

        
    }
}
