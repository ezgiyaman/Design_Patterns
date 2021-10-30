using DecoratorPattern.Example1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Example1.Concrete
{
    class CheeseDecorator : IPizza
    {
        private IPizza _pizza;
        public CheeseDecorator(IPizza pizza) => this._pizza = pizza;
        
        public string GetPizzaType() => _pizza.GetPizzaType() + " ekstra peynir eklendi. ";
       
    }
}
