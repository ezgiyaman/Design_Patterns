using ObserverPattern.Example1.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Example1.Concrete
{
    public class CustomerObserver : BaseObserver
    {
        public string UserName { get; set; }
        public override void Update() => Console.WriteLine("Değerli Müşterilerimiz,ürün mağazaya geldi.");

    }
}
