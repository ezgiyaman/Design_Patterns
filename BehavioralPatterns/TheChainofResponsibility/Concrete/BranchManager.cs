using System;
using System.Collections.Generic;
using System.Text;
using TheChainofResponsibility.Abstract;
using TheChainofResponsibility.Model;

namespace TheChainofResponsibility.Concrete
{
    public class BranchManager : Customer
    {
        public override void HandlerCredit(Credit credit)
        {
            if (credit.Amount > 15000)
            {
                Console.WriteLine("Şube müdürü ödemeyi yapar.");
            }
        }
    }
}
