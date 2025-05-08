using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UretimPazari.Entities.Models;

namespace UretimPazari.Repositories.Contracts
{
    public interface ICategoryRepository:IRepositoryBase<Category>
    {
        IEnumerable<Category> GetAllCategories(bool trackChanges);
        Category? GetOneCategory(int id, bool trackChanges);
        void CreateCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
    }
}
