using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UretimPazari.Entities.Models;
using UretimPazari.Repositories.Contracts;

namespace UretimPazari.Repositories
{
    public class SupplierRepository : RepositoryBase<Supplier>, ISupplierRepository
    {
        public SupplierRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateSupplier(Supplier supplier)
        {
            CreateSupplier(supplier);
        }

        public void DeleteSupplier(Supplier supplier)
        {
            DeleteSupplier(supplier);
        }

        public IEnumerable<Supplier> GetAllSuppliers(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

        public Supplier? GetOneSupplier(int id, bool trackChanges)
        {
            return FindByCondition(s => s.SupplierId == id, trackChanges).SingleOrDefault();
        }

        public void UpdateSupplier(Supplier supplier)
        {
            UpdateSupplier(supplier);
        }
    }
}
