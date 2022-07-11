using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining
{
    class Program
    {
        static void Main(string[] args)
        {
            sample spl = new sample();
            Console.WriteLine(spl.str);

            derivedSample2 dsp = new derivedSample2(10, 10, 5);
            Console.WriteLine(dsp.Add(10,5));
            Console.WriteLine(dsp.Sub(10,5));
            Console.ReadLine();
        }
    }
}
