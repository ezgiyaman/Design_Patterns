using FactoryMethod.Example1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Example1.Creator
{
    public class VanillaIceCream : IIceCream
    {
        public string Variationlity() => "Vanilla Ice cream";
       
    }
}
