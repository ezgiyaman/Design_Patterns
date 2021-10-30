using BuilderPattern.Example1.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Example1.Abstract
{
    public abstract class PhoneBuilder
    {
        protected Phone phone;
        public Phone Phone
        {
            get { return phone; }
           
        }
        public abstract void SetBrand();
        public abstract void SetModel();
        public abstract void SetPrice();

    }
}
