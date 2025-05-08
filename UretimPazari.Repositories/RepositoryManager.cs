using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UretimPazari.Repositories.Contracts;

namespace UretimPazari.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;

        private readonly IProductRepository _productRepository;
        private readonly IProducerRepository _producerRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IContactRepository _contactRepository;
        private readonly IAboutRepository _aboutRepository;
        private readonly IHomePageContentRepository _homePageContentRepository;
        private readonly IOfferRepository _offerRepository;
        private readonly ISupplierRepository _supplierRepository;
        private readonly IUserRepository _userRepository;

        public RepositoryManager(
            IProductRepository productRepository,
            RepositoryContext context,
            ICategoryRepository categoryRepository,
            IProducerRepository producerRepository,
            IContactRepository contactRepository,
            IAboutRepository aboutRepository,
            IHomePageContentRepository homePageContentRepository,
            IOfferRepository offerRepository,
            ISupplierRepository supplierRepository,
            IUserRepository userRepository
        )
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _producerRepository = producerRepository;
            _contactRepository = contactRepository;
            _aboutRepository = aboutRepository;
            _homePageContentRepository = homePageContentRepository;
            _offerRepository = offerRepository;
            _supplierRepository = supplierRepository;
            _userRepository = userRepository;
            _context = context;
        }

        public IProductRepository Product => _productRepository;
        public IProducerRepository Producer => _producerRepository;
        public ICategoryRepository Category => _categoryRepository;
        public IContactRepository Contact => _contactRepository;
        public IAboutRepository About => _aboutRepository;
        public IHomePageContentRepository HomePageContent => _homePageContentRepository;
        public IOfferRepository Offer => _offerRepository;
        public ISupplierRepository Supplier => _supplierRepository;
        public IUserRepository User => _userRepository;

        public void Save() => _context.SaveChanges();
    }
}
