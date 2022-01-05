
using Mediator_Pattern.Example1.Concrete;
using Mediator_Pattern.Example1.Interface;
using Mediator_Pattern.Example1.Mediator.Concrete;
using Mediator_Pattern.Example1.Mediator.Interface;
using System;

namespace Mediator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example1

            IChatMediator chatMediator = new ChatMediator();

            IUser zeynep = new BasicUser(chatMediator,"zeynep");
            IUser ceren = new GoldUser(chatMediator, "ceren");
      
            chatMediator.AddUser(zeynep);
            chatMediator.AddUser(ceren);

            zeynep.SendMessage("Selam..");
           

            #endregion

            #region Example2








            #endregion

            Console.ReadKey();
        }
    }
}
