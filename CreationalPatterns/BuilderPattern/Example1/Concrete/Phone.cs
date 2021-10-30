using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Example1.Concrete
{
    public class Phone
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public String Price { get; set; }
        public override string ToString()
        {
            return $"{Brand} marka telefon {Model} modelinde {Price} fiyatıyla üretilmiştir.";
        }
    }
}
