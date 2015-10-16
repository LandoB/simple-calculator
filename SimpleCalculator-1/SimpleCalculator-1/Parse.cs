using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator1
{
    public class Parse
    {
        private double value1;
        private double value2;
        private char operador;

        public double Value1
        {
            get { return value1; }
            set { value1 = value; }
        }

        public double Value2
        {
            get { return value2; }
            set { value2 = value; }
        }

        public char Operador
        {
            get { return operador; }
            set { operador = value; }
        }

        public string ReadInput(string input)
        {
            // Split produces an array of string based on the separator symbols.
            // The separator symbols will not be included in the array.
            var currentInput = input.Split(new char[] { '+', '-', '*', '/', '%' });
            // I must parse to the data type I want.
            var value1 = double.Parse(currentInput[0]);
            // same here. I must parse the data type I want.
            var value2 = double.Parse(currentInput[1]);
            string operation;

            // contains looks for the existence of the item.
            if (input.Contains("+"))
                operation = "+";
            else if (input.Contains("-"))
                operation = "-";
            else if (input.Contains("*"))
                operation = "*";
            else if (input.Contains("/"))
                operation = "/";
            else if (input.Contains("%"))
                operation = "%";
            else
                throw new InvalidOperationException();

            return Calculate(value1, value2, operation).ToString();

        }

        public double Calculate(double value1, double value2, string operation)
        {
            var value = 0.0;

            switch (operation)
            {
                case "+":
                    value = value1 + value2;
                    break;
                case "-":
                    value = value1 - value2;
                    break;
                case "*":
                    value = value1 * value2;
                    break;
                case "/":
                    value = value1 / value2;
                    break;
                case "%":
                    value = value1 % value2;
                    break;
                default:
                    throw new InvalidOperationException();
            }

            return value;
        }




    }
}
