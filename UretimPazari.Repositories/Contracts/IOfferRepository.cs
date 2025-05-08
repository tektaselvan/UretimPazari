using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UretimPazari.Entities.Models;

namespace UretimPazari.Repositories.Contracts
{
    public interface IOfferRepository:IRepositoryBase<Offer>
    {
        IEnumerable<Offer> GetAllOffers(bool trackChanges);
        Offer? GetOneOffer(int id, bool trackChanges);
        void CreateOffer(Offer offer);
        void UpdateOffer(Offer offer);
        void DeleteOffer(Offer offer);
    }
}
