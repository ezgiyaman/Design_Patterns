using FactoryMethod.Example1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Example1.Creator
{
    public class StrawberryIceCream : IIceCream
    {
        public string Variationlity() => "Strawberry Ice cream";

    }
}
