using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestFactoryMethod
{
    class Futures: Derivative
    {
        public Futures(string symbol, string underlying, int year, int month)
            : base(symbol, underlying, year, month)
        {
           
        }

        public override double TheoraticalPrice()
        {
            return 1;
        }
    }
}
