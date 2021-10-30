using FactoryMethod.Example1.Creator;
using FactoryMethod.Example1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Example1.FactoryCreator
{
    public class Factory
    {
        public static  IIceCream Get(int id)
        {
            switch (id)
            {
                case 0:
                    return new ChocolateIceCream();
                case 1:
                    return new VanillaIceCream();
                case 2:
                    return new StrawberryIceCream();
                default:
                    return null;
            }
        }
    }
}
