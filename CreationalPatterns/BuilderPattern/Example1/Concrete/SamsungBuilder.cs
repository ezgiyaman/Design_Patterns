using BuilderPattern.Example1.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Example1.Concrete
{
    public class SamsungBuilder : PhoneBuilder
    {
        public SamsungBuilder() => phone = new Phone();
        public override void SetBrand() => phone.Brand = "Samsung";
        public override void SetModel() => phone.Model = "S20";
        public override void SetPrice() => phone.Price = "11.000";

    }
}
