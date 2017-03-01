using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestFactoryMethod
{

    //Parameterised Factory Method
    class MarketCreator
    {
        public virtual IMarket Create(int i)
        {
            return null;
        }
    }

    class ConcreteMarketCreator : MarketCreator
    {
        public override IMarket Create(int i)
        {
            if (i == 1)
            {
                return new Market1();
            }
            else if (i == 2)
            {
                return new Market2();
            }
            else if (i == 3)
            {
                return new Market3();
            }
            else
            {
                return base.Create(i);
            }
        }
    }
}
