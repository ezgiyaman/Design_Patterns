using System;
using System.Collections.Generic;
using System.Text;
using TheChainofResponsibility.Model;

namespace TheChainofResponsibility.Abstract
{
    public abstract class Customer
    {
        protected Customer _nextHandler;
        public void SetHandler(Customer nextHandler) => _nextHandler = nextHandler;

        public abstract void HandlerCredit(Credit credit);
    }
}
