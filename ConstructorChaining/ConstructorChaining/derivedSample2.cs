using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining
{
    public class derivedSample2:derivedSample1
    {
        public int m;
        public derivedSample2(int m1,int a1,int b1):base(a1,b1)
        {
            this.m = m1;
        }
        public int Sub(int a, int b)
        {
            return (a - b);
        }
    }
}
