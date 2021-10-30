using FactoryMethod.Example1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Example1.Creator
{
    public class ChocolateIceCream : IIceCream
    {
        public string Variationlity() => "Chocolate Ice cream";
       
    }
}
