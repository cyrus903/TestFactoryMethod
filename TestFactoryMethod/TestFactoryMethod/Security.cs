using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestFactoryMethod
{
    class Security: Tradable
    {
        public Security(string symbol)
            : base(symbol)
        {    
        }


    }
}
