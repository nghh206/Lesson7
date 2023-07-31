﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DataContexts;
using DataLayer.Interface;
using Entities;
using Microsoft.EntityFrameworkCore;


namespace DataLayer.Repositories
{
    public class ContactRespository : IContactRespository
    {
        public List<Contact> GetAll()
        {
            using (var context = new ContactContext())
            {
                return context.Contact.ToList();
            }
        }
        public Contact GetByID(int id)
        {
            using (var context = new ContactContext())
            {
                return context.Contact.Find(id);
            }
        }
        public Contact Create(Contact contact)
        {
            using (var context = new ContactContext())
            {
                context.Contact.Add(contact);
                context.SaveChanges();
                return contact;
            }
        }
        public void Update(Contact contact)
        {
            using (var context = new ContactContext())
            {
                context.Contact.Attach(contact);
                context.Entry(contact).State = EntityState.Modified;
                context.SaveChanges();
     
            }
        }
        public void Delete(Contact contact)
        {
            using (var context = new ContactContext()) 
            {
                context.Contact.Attach(contact);
                context.Contact.Remove(contact);
                context.SaveChanges();
            }
        }
    }
}
