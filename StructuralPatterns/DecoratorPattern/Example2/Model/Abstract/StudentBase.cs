using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Example2.Model.Abstract
{
    public abstract class StudentBase
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public abstract decimal RegistrationFee{ get; set; }
    }
}
