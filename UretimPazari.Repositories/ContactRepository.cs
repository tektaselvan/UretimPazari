using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UretimPazari.Entities.Models;
using UretimPazari.Repositories.Contracts;

namespace UretimPazari.Repositories
{
    public class ContactRepository : RepositoryBase<Contact>, IContactRepository
    {
        public ContactRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateContact(Contact contact)
        {
            CreateContact(contact);
        }

        public void DeleteContact(Contact contact)
        {
            DeleteContact(contact);
        }

        public IEnumerable<Contact> GetAllContacts(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

        public Contact? GetOneContact(int id, bool trackChanges)
        {
            return FindByCondition(c=>c.ContactId==id,trackChanges).SingleOrDefault();
        }

        public void UpdateContact(Contact contact)
        {
            UpdateContact(contact);
        }
    }
}
