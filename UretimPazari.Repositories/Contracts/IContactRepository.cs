using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UretimPazari.Entities.Models;

namespace UretimPazari.Repositories.Contracts
{
    public interface IContactRepository:IRepositoryBase<Contact>
    {
        IEnumerable<Contact> GetAllContacts(bool trackChanges);
        Contact? GetOneContact(int id, bool trackChanges);
        void CreateContact(Contact contact);
        void UpdateContact(Contact contact);
        void DeleteContact(Contact contact);
    }
}
