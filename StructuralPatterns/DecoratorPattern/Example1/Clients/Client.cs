using DecoratorPattern.Example1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Example1.Clients
{
    public class Client
    {
        public static void Presentation(String s,IPizza pizza)
        {
            Console.WriteLine(s + pizza.GetPizzaType());
        }
    }
}
