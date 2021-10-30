using BuilderPattern.Example1.Abstract;
using BuilderPattern.Example1.Concrete;
using BuilderPattern.Example1.Director;
using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example1

            PhoneBuilder phone = new IphoneBuilder();
            ManufacturingDirector md = new ManufacturingDirector();
            md.Manufacturing(phone);

            Console.WriteLine(phone.Phone.ToString());

            PhoneBuilder phones = new SamsungBuilder();
            md.Manufacturing(phones);

            Console.WriteLine(phones.Phone.ToString());

            #endregion

            Console.ReadKey();

        }
    }
}
