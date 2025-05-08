using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UretimPazari.Entities.Models;
using UretimPazari.Repositories.Contracts;
using UretimPazariServices.Contracts;

namespace UretimPazariServices
{
    public class CategoryManager:ICategoryService
    {
        private readonly IRepositoryManager _repositoryManager;

        public CategoryManager(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public void CreateCategory(Category category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category), "Category cannot be null.");
            }

            _repositoryManager.Category.CreateCategory(category);
            _repositoryManager.Save();
        }

        public void DeleteCategory(int id)
        {
            var category = _repositoryManager.Category.GetOneCategory(id, trackChanges: false);
            if (category == null)
            {
                throw new Exception("Category not found.");
            }

            _repositoryManager.Category.DeleteCategory(category);
            _repositoryManager.Save();
        }

        public IEnumerable<Category> GetAllCategories(bool trackChanges)
        {
            return _repositoryManager.Category.GetAllCategories(trackChanges);
        }

        public Category? GetOneCategory(int id, bool trackChanges)
        {
            var category = _repositoryManager.Category.GetOneCategory(id, trackChanges);
            if (category is null)
                throw new Exception("Category not found");

            return category;
        }

        public void UpdateCategory(Category category)
        {
            var existingCategory = _repositoryManager.Category.GetOneCategory(category.CategoryId, trackChanges: true);
            if (existingCategory == null)
            {
                throw new Exception("Category not found.");
            }

            _repositoryManager.Category.UpdateCategory(category);
            _repositoryManager.Save();
        }
    }
}
