using DecoratorPattern.Example2.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Example2.Model.Concrete
{
    public class WarVeteranDiscount : StudentBase
    {
        public override decimal RegistrationFee { get; set ; }
    }
}
