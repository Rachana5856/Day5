using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining
{
    public class derivedSample1
    {
        public int a;
        public int b;
        public derivedSample1(int a1,int b1)
        {
            this.a = a1;
            this.b = b1;
        }

        public int Add(int a, int b)
        {
            return (a + b);
        }
    }
}
