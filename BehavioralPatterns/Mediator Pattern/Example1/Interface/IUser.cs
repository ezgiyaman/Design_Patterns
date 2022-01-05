using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Pattern.Example1.Interface
{
    public interface IUser
    {
        void SendMessage(string message);
        void ReceiveMessage(string message);
    }
}
