using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestFactoryMethod
{
    class Creator
    {
        public virtual IMarket Create()
        {
            return null;
        }
    }

    class GenericCreator<T> : Creator where T: IMarket, new() 
    {
        public override IMarket Create()
        {
            return new T();
        }
    }
}
