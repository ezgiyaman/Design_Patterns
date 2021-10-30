using System;
using System.Collections.Generic;
using System.Text;
using TheChainofResponsibility.Abstract;
using TheChainofResponsibility.Model;

namespace TheChainofResponsibility.Concrete
{
    public class Teller : Customer
    {
        public override void HandlerCredit(Credit credit)
        {
            if (credit.Amount <= 5000)
            {
                Console.WriteLine("Gişe memuru ödemeyi yapar.");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandlerCredit(credit);
            }
        }
    }
}
