using DecoratorPattern.Example1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Example1.Concrete
{
    class Pizza : IPizza
    {
        public string GetPizzaType() => "Sade bir pizzaya";
       
    }
}
