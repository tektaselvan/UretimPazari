using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UretimPazari.Entities.Models;
using UretimPazari.Repositories.Contracts;

namespace UretimPazari.Repositories
{
    public class OfferRepository : RepositoryBase<Offer>, IOfferRepository
    {
        public OfferRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateOffer(Offer offer)
        {
            CreateOffer(offer);
        }

        public void DeleteOffer(Offer offer)
        {
            DeleteOffer(offer);
        }

        public IEnumerable<Offer> GetAllOffers(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

        public Offer? GetOneOffer(int id, bool trackChanges)
        {
            return FindByCondition(o => o.OfferId == id,trackChanges).SingleOrDefault();
        }

        public void UpdateOffer(Offer offer)
        {
            UpdateOffer(offer);
        }
    }
}
