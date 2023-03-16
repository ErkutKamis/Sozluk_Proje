using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessage _message;

        public MessageManager(IMessage message)
        {
            _message = message;
        }

        public Message GetById(int id)
        {
            return _message.Get(x => x.Id == id);
        }

        public List<Message> GetListInbox(string p)
        {

            return _message.List(x => x.ReceiverMail == p);
        }

        public List<Message> GetListSendBox(string p)
        {
            return _message.List(x => x.SenderMail == p);
        }

        public void MessageAdd(Message message)
        {
            _message.Insert(message);
        }

        public void MessageDelete(Message message)
        {
            throw new NotImplementedException();
        }

        public void MessageUpdate(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
