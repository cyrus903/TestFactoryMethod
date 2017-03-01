using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestFactoryMethod
{
    class Application
    {
        public void Run()
        {            
            //Market1 mkt = new Market2(); //ok
            //Market1 mkt = new Market2(); //ok
            //Market3 mkt = new Market2(); //not ok
            //IMarket mkt = new Market2(); //ok

            //IMarket mkt = CreateMarket(); //Factory Method

            //MarketCreator mc = new ConcreteMarketCreator();
            //IMarket mkt = mc.Create(2); //Parameterised Factory Method

            Creator gc = new GenericCreator<Market1>(); //Generic Creator
            IMarket mkt = gc.Create();
        }

        private IMarket CreateMarket() //Factory Method
        {
            return new Market2(); //Change this line to switch to different markets
        }
    }
}
