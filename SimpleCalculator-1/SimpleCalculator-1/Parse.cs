using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator1
{
    public class Parse
    {
        // Chunk 1
        private int value1;
        private int value2;
        private char operador;

        public int Value1
        {
            get { return value1; }
            set { value1 = value; }
        }

        public int Value2
        {
            get { return value2; }
            set { value2 = value; }
        }

        public char Operador
        {
            get { return operador; }
            set { operador = value; }
        }

        public void ControllerCheckInput(string input)
        {
            if (input.Contains("+") || input.Contains("-") || input.Contains("*") || input.Contains("/") || input.Contains("%"))
            {
                ReadInput(input);
            }
            else
            {
                // Stack myInput = new Stack();
                Stack myInput = StackSingleton.Instance;
                myInput.RunKeywordEvaluation(input);
            }
        }


        public void ReadInput(string input)
        {
            // Split produces an array of string based on the separator symbols.
            // The separator symbols will not be included in the array.
            var currentInput = input.Split(new char[] { '+', '-', '*', '/', '%' });
            // I must parse to the data type I want.
            try
            {
                Value1 = int.Parse(currentInput[0]);
            }
            catch (Exception) {
                Console.WriteLine("Please enter a valid number.");
            }
            // same here. I must parse the data type I want.
            try
            {
                Value2 = int.Parse(currentInput[1]);
            }

            catch (Exception)
            {
                Console.WriteLine("Please enter a valid number.");
            }
            
            char operation;

            // contains looks for the existence of the item.
            if (input.Contains("+"))
                operation = '+';
            else if (input.Contains("-"))
                operation = '-';
            else if (input.Contains("*"))
                operation = '*';
            else if (input.Contains("/"))
                operation = '/';
            else if (input.Contains("%"))
                operation = '%';
            else {
                Console.WriteLine("Please enter a valid operator.");
                throw new InvalidOperationException();

            }

            Operador = operation;
            Evaluate evaluator = new Evaluate();
            evaluator.RunOperation(value1, value2, operation);
        }


    }
}

