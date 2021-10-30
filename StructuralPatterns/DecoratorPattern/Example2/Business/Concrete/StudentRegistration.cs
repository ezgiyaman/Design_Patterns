using DecoratorPattern.Example2.Business.Abstract;
using DecoratorPattern.Example2.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Example2.Business.Concrete
{
    public class StudentRegistration : StudentDecoratorBase
    {
        private StudentBase _studentBase;

        //base(studentBase) eklendi.Çünkü sınıflar initilialize edilirken gelen parametre her iki tarafta da kullanılabilsin.

        public StudentRegistration(StudentBase studentBase) : base(studentBase) 
        {
            this._studentBase = studentBase;
        }
        public int DiscountedPercantege { get; set; }
        public override decimal RegistrationFee
        {
            get => _studentBase.RegistrationFee * DiscountedPercantege / 100;
            set { }
        }
    }
}
