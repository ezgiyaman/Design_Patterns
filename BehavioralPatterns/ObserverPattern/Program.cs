

using ObserverPattern.Example1;
using ObserverPattern.Example1.Concrete;
using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerObserver = new CustomerObserver();

            Product product = new Product();
            product.Attached(new StoreEmployeeObserver());
            product.Attached(customerObserver);
            product.UpdateColour();
            product.UpdatePrice();

            Console.ReadKey();

        }
    }
}
