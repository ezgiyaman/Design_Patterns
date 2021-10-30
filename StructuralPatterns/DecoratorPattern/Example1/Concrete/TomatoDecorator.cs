using DecoratorPattern.Example1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Example1.Concrete
{
    class TomatoDecorator : IPizza
    {
        private IPizza _pizza;
        public TomatoDecorator(IPizza pizza) => this._pizza = pizza;
        public string GetPizzaType() => _pizza.GetPizzaType() + " ekstra domates eklendi.";
       
    }
}
