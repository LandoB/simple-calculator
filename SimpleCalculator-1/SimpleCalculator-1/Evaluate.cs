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

        private double myResult;
        private double resultado;

        public double Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public void RunEvaluation(double value1, double value2, char operation)
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
            
            Stack.LastInput = value1.ToString() + operation.ToString() + value2.ToString();
            Stack.LastAnswer = resultado.ToString(); 

        }
    }
}
