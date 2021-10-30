using BuilderPattern.Example1.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Example1.Concrete
{
    public class IphoneBuilder : PhoneBuilder
    {
        public IphoneBuilder() => phone = new Phone();
        public override void SetBrand() => phone.Brand = "Iphone";
        public override void SetModel() => phone.Model = "12";
        public override void SetPrice() => phone.Price = "13.000";

    }
}
