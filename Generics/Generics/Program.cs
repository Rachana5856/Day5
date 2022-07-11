using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Calculator
    {
        public static bool AreEqual<t>(t value1, t value2)
        {
            return value1.Equals(value2);
        }
        static void Main(string[] args)
        {
            bool equal = Calculator.AreEqual<string>("ab", "ab");
                if(equal)
                {
                    Console.WriteLine("Equal");
                }
                else
                {
                    Console.WriteLine("Not-Equal");
                }
                Console.ReadLine();
        }
    }
}
