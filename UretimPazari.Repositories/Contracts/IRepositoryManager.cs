using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UretimPazari.Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IProductRepository Product { get; }
        IProducerRepository Producer { get; }
        ICategoryRepository Category { get; }
        IContactRepository Contact { get; }
        IAboutRepository About { get; }
        IHomePageContentRepository HomePageContent { get; }
        IOfferRepository Offer { get; }
        ISupplierRepository Supplier { get; }
        IUserRepository User { get; }

        void Save();

    }
}
