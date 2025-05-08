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
    public class ProductManager : IProductService
    {
        private readonly IRepositoryManager _repositoryManager;

        public ProductManager(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }


        public void CreateProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "Product cannot be null.");
            }

            _repositoryManager.Product.CreateProduct(product);
            _repositoryManager.Save();
        }

        public void DeleteProduct(int id)
        {
            var product = _repositoryManager.Product.GetOneProduct(id, trackChanges: false);
            if (product == null)
            {
                throw new Exception("Product not found.");
            }

            _repositoryManager.Product.DeleteProduct(product);
            _repositoryManager.Save();
        }

        public IEnumerable<Product> GetAllProducts(bool trackChanges)
        {
            return _repositoryManager.Product.GetAllProducts(trackChanges);
        }

        public Product? GetOneProduct(int id, bool trackChanges)
        {
            var product = _repositoryManager.Product.GetOneProduct(id, trackChanges);
            if (product is null)
                throw new Exception("Product not found");

            return product;
        }

        public void UpdateProduct(Product product)
        {
            var existingProduct = _repositoryManager.Product.GetOneProduct(product.ProductId, trackChanges: true);
            if (existingProduct == null)
            {
                throw new Exception("Product not found.");
            }

            _repositoryManager.Product.UpdateProduct(product);
            _repositoryManager.Save();
        }
    }
}
