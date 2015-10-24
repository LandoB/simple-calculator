using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator1
{
    public class StackSingleton
    {
        static private Stack _instance = new Stack();

        public static Stack Instance  { get { return _instance; } }
    }
}
