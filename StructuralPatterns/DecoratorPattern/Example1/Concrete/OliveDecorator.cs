using DecoratorPattern.Example1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Example1.Concrete
{
    public class OliveDecorator : IPizza
    {
        private IPizza _pizza;
        public OliveDecorator(IPizza pizza) => this._pizza = pizza;
        public string GetPizzaType() => _pizza.GetPizzaType() + " ekstra zeytin eklendi. ";
        
    }
}
