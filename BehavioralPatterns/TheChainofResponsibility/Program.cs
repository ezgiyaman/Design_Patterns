using System;
using System.Collections.Generic;
using TheChainofResponsibility.Concrete;
using TheChainofResponsibility.Model;

namespace TheChainofResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Teller teller = new Teller();
            BranchManager branchManager = new BranchManager();
            UnitManager unitManager = new UnitManager();

            teller.SetHandler(unitManager);
            unitManager.SetHandler(branchManager);

            List<Credit> credits = new List<Credit>()
            {
                new Credit{FirstName = "Aslı", LastName ="Yılmaz",Amount =3250},
                new Credit{FirstName = "Burcu", LastName = "Yıldız",Amount = 15500},
            };
            foreach (Credit credit in credits)
                branchManager.HandlerCredit(credit);
            Console.ReadKey();

        }
    }
}
