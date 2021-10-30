using DecoratorPattern.Example2.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Example2.Business.Abstract
{
    public abstract class StudentDecoratorBase : StudentBase
    {
        private StudentBase _studentbase;
        public StudentDecoratorBase(StudentBase studentBase) => this._studentbase = studentBase;
        
    }
}
