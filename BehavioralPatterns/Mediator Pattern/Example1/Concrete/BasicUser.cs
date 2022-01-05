using Mediator_Pattern.Example1.Interface;
using Mediator_Pattern.Example1.Mediator.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Pattern.Example1.Concrete
{
    public class BasicUser : IUser
    {
        string _userName;
        IChatMediator _chatmediator;

        public BasicUser(IChatMediator chatMediator, string userName)
        {
            this._chatmediator = chatMediator;
            this._userName = userName;
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"Kullanıcı Tipi: Basic\nKullanıcı Adı: {_userName}\nAlınan Mesaj: {message}");
        }

        public void SendMessage(string message)
        {
            _chatmediator.SendMessage(message, this);
        }
    }
}
