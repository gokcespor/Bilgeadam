using MediatorPattern.Interface;
using MediatorPattern.Mediator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Mediator.Concrete
{
    public class ChatMediator : IChatMediator
    {
        private List<IUser> _users;
        public ChatMediator() 
        {
            _users = new List<IUser>(); 
        }
        public void AddUser(IUser user)
        {
            _users.Add(user);
        }

        public void SendMessage(string message, IUser sender)
        {
            foreach (IUser user in _users)
            {
                user.ReceiveMessage(message);
            }
        }
    }
}
