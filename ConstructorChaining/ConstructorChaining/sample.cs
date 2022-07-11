using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining
{
    class sample
    {
        //constructor chaning in same class
        public string str;
        public sample():this("company")
        {

        }
        public sample(string strg)
        {
            this.str = strg;
        }
    }
}
