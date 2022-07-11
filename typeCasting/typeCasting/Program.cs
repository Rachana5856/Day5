using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            string s = null;
            string x = "123";
            int b;

            string input = Console.ReadLine();
            int X = int.Parse(input);
            Console.WriteLine(X);

            Console.WriteLine(int.Parse(x));
            Console.WriteLine(int.TryParse(x, out b));
            Console.WriteLine(Convert.ToInt32(s));

            Console.WriteLine(Convert.ToString(myInt));    // Convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // Convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // Convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // Convert bool to string
            Console.ReadLine();
        }
    }
}
