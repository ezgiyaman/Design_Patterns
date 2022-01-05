using Mediator_Pattern.Example1.Interface;
using Mediator_Pattern.Example1.Mediator.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Pattern.Example1.Mediator.Concrete
{
    public class ChatMediator : IChatMediator
    {
        private List<IUser> users;
        
        public ChatMediator()
        {
            users = new List<IUser>();
        }
        public void AddUser(IUser user)
        {
            users.Add(user);
        }

        public void SendMessage(string message, IUser sender)
        {
            foreach (IUser user in users)
            {
                if(user != sender)
                {
                    user.ReceiveMessage(message);
                }
            }
        }
    }
}
