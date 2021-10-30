using System;
using System.Collections.Generic;
using System.Text;
using TheChainofResponsibility.Abstract;
using TheChainofResponsibility.Model;

namespace TheChainofResponsibility.Concrete
{
    public class UnitManager : Customer
    {
        public override void HandlerCredit(Credit credit)
        {
            if (credit.Amount > 5000 && credit.Amount <= 15000)
            {
                Console.WriteLine("Birim müdürü ödemeyi yapar.");
            }

            else if (_nextHandler != null)
            {
                _nextHandler.HandlerCredit(credit);
            }
        }
    }
}
