using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator1
{
    public class Calculate
    {
        private int counter = 0; // It's private because no one else should care about this but this class.

        public void RunCalculator()
        {
            Console.Write("[" + counter + "]>");
            string input = Console.ReadLine();
            Parse parser = new Parse();

            if (input != "exit" || input != "quit") {
                parser.ReadInput(input);
                counter++;
                RunCalculator();
            }
        }
    }
}
