using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator1
{
    public static class Stack
    {
        // Chunk 3
        private static string myWord; // This will contain the word that the user typed
        private static string lastInput; // Last Evaluated Expresion - "lastq"
        private static string lastAnswer; // Last Answer - "last"

        public static string LastInput
        {
            get { return lastInput; }
            set { lastInput = value; }
        }

        public static string LastAnswer
        {
            get { return lastAnswer; }
            set { lastAnswer = value; }
        }

        public static void RunKeywordEvaluation(string myKeyword)
        {
            switch (myKeyword)
            {
                case "last":
                    myWord = lastAnswer;
                    break;
                case "lastq":
                    myWord = lastInput;
                    break;
                default:
                    throw new ArgumentException();
            }

        }
    }
}
