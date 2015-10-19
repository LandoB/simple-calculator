using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator1
{
    public class Calculate
    {
        public void RunCalculator()
        {
            Action actionCode;
            string lastInput = "", input;
            int lastAnswer = 0, answer = 0;

            do
            {
                input = ReadInput(input);
                actionCode = ValidateInput(input);
                DoAnAction(actionCode, lastAnswer, lastInput, out answer);

                // if actionCode = math code, then save answer to lastAnswer
                if (actionCode >= Action.ADD && actionCode <= Action.MODULUS)
                {
                    lastAnswer = answer;
                    lastInput = input;
                }

            } while (actionCode != Action.EXIT);


        }
    }
}
