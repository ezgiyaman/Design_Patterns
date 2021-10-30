using BuilderPattern.Example1.Abstract;
using BuilderPattern.Example1.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Example1.Director
{
    public  class ManufacturingDirector //nesne üretimini gerçekleştiren sınıf
    {
        public void Manufacturing(PhoneBuilder phone)
        {
            phone.SetBrand();
            phone.SetModel();
            phone.SetPrice();
        }
    }
}
