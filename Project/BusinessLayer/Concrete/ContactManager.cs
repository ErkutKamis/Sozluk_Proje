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
    public class ContactManager : IContactService
    {
        readonly IContact _contact;

        public ContactManager(IContact contact)
        {
            _contact = contact;
        }

        public void ConctactUpdate(Contact contact)
        {
            _contact.Update(contact);
        }

        public void ContactAdd(Contact contact)
        {
            _contact.Insert(contact);
        }

        public void ContactDelete(Contact contact)
        {
            _contact.Delete(contact);
        }

        public Contact GetById(int id)
        {
            return _contact.Get(x => x.Id == id);
        }

        public List<Contact> GetList()
        {
            return _contact.List();
        }
    }
}
