using ObserverPattern.Example1.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Example1
{
    public class Product
    {
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }

        List<BaseObserver> _observers;
        public Product() => _observers = new List<BaseObserver>();

        public void UpdatePrice()
        {
            Console.WriteLine("Ürün fiyatı değişti.");
        }
        public void UpdateColour()
        {
            Console.WriteLine("Yeni kırmızı renk geldi.");
            Notification();
        }
        public void Notification()
        {
            foreach (var item in _observers)
            {
                item.Update();
            }
        }
        public void Attached(BaseObserver baseObserver) => _observers.Add(baseObserver);
        public void Detached(BaseObserver baseObserver) => _observers.Remove(baseObserver);



    }
}
