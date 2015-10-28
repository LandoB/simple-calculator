using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator1
{
    public class Stack
    {
        // Chunk 3
        //private string myWord; // This will contain the word that the user typed
        private string lastInput; // Last Evaluated Expresion - "lastq"
        private string lastAnswer; // Last Answer - "last"
        private string exitQuit = "Bye!";

        public string LastInput
        {
            get { return lastInput; }
            set { lastInput = value; }
        }

        public string LastAnswer
        {
            get { return lastAnswer; }
            set { lastAnswer = value; }
        }

        public string RunKeywordEvaluation(string myWord)
        {
            string myOutput;
            switch (myWord)
            {
                case "last":
                    myOutput = lastAnswer;
                    Console.WriteLine(myOutput);
                    break;
                case "lastq":
                    myOutput = lastInput;
                    Console.WriteLine(myOutput);
                    break;
                case "exit":
                    myOutput = exitQuit;
                    Console.WriteLine(myOutput);
                    Console.ReadLine();
                    break;
                case "quit":
                    myOutput = exitQuit;
                    Console.WriteLine(myOutput);
                    Console.ReadLine();
                    break;
                default:
                    throw new ArgumentException();
            }

            return myOutput;

        }

        // Chunk 4 - Constants

        // Initialize the Dictionary
        public Dictionary<string, int> Constants = new Dictionary<string, int>();

        // Add a given Constant to the Dictionary

        public bool AddConstantToDictionary(string key, int value)
        {
            if (!ConstantIsInDictionary(key))
            {
                Constants.Add(key, value);
                return true;
            }
            else
            {
                throw new ArgumentException();
            }

        }

        // Look for a value in the Dictionary

        public bool ConstantIsInDictionary(string key)
        {
            if (Constants.ContainsKey(key))
            {
                return true;
            }
            return false;
        }


        // Get a Constant Value from the Dictionary

        public int ReturnConstantValue(string key)
        {
            try
            {
                return Constants[key];
            }
            catch (KeyNotFoundException)
            {
                throw;
            }

        }

    }
}
