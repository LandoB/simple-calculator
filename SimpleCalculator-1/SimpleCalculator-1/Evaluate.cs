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


        public void Calculate(double value1, double value2, char operation)
        {
            // var myResult = 0.0;

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
            
            
        }
    }
}
