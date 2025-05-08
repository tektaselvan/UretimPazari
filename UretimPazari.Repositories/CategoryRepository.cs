using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UretimPazari.Entities.Models;
using UretimPazari.Repositories.Contracts;

namespace UretimPazari.Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateCategory(Category category)=>CreateCategory(category);

        public void DeleteCategory(Category category)=>DeleteCategory(category);

        public IEnumerable<Category> GetAllCategories(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

        public Category? GetOneCategory(int id, bool trackChanges)
        {
            return FindByCondition(c => c.CategoryId == id, trackChanges).SingleOrDefault();
        }

        public void UpdateCategory(Category category)=>UpdateCategory(category);
    }
}
