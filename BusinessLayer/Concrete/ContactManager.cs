﻿using BusinessLayer.Abstract;
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
        IContact _contact;

        public ContactManager(IContact contact)
        {
            _contact = contact;
        }

        public void TAdd(Contact t)
        {
            _contact.Insert(t);
        }

        public void TDelete(Contact t)
        {
            _contact.Delete(t);
        }

        public Contact TGetByID(int id)
        {
            return _contact.GetByID(id);
        }

        public List<Contact> TGetList()
        {
           return _contact.GetList();
        }

        public void TUpdate(Contact t)
        {
            _contact.Update(t);
        }
    }
}
