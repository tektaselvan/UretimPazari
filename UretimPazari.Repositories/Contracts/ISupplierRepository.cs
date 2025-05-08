using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UretimPazari.Entities.Models;

namespace UretimPazari.Repositories.Contracts
{
    public interface ISupplierRepository:IRepositoryBase<Supplier>
    {
        IEnumerable<Supplier> GetAllSuppliers(bool trackChanges);
        Supplier? GetOneSupplier(int id, bool trackChanges);
        void CreateSupplier(Supplier supplier);
        void UpdateSupplier(Supplier supplier);
        void DeleteSupplier(Supplier supplier);
    }
}
