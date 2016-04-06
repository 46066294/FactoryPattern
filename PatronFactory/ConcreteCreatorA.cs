using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatronFactory
{
    class ConcreteCreatorA : Creator
    {
        public Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }
}
