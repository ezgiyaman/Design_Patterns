using Mediator_Pattern.Example1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Pattern.Example1.Mediator.Interface
{
    public interface IChatMediator
    {
        void AddUser(IUser user);
        void SendMessage(string message, IUser sender);
    }
}
