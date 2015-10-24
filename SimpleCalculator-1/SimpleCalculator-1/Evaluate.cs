using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator1
{
    public class Evaluate
    {
        // Chunk 2

        private int myResult;
        private int resultado;

        Stack myInput = StackSingleton.Instance;

        public int Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public void RunOperation(int value1, int value2, char operation)
        {
            switch (operation)
            {
                case '+':
                    myResult = value1 + value2;
                    break;
                case '-':
                    myResult = value1 - value2;
                    break;
                case '*':
                    myResult = value1 * value2;
                    break;
                case '/':
                    myResult = value1 / value2;
                    break;
                case '%':
                    myResult = value1 % value2;
                    break;
                default:
                    throw new InvalidOperationException();
            }

            Resultado = myResult;
            Console.WriteLine(myResult);
            
            myInput.LastInput = value1.ToString() + operation.ToString() + value2.ToString();
            myInput.LastAnswer = resultado.ToString();
        }
    }
}
