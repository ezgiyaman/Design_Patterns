using ObserverPattern.Example1.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Example1.Concrete
{
    public class StoreEmployeeObserver : BaseObserver
    {
        public string EmployeeName { get; set; }
        public override void Update() => Console.WriteLine("Değerli Çalışanlarımız ,ürün mağazaya geldi.");


    }
}
