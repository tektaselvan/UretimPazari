using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UretimPazari.Entities.Models;
using UretimPazari.Repositories.Contracts;

namespace UretimPazari.Repositories
{
    public class ListingRepository : RepositoryBase<Listing>, IListingRepository
    {
        public ListingRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateListing(Listing listing)=> CreateListing(listing);

        public void DeleteListing(Listing listing)=>DeleteListing(listing);
        

        public IEnumerable<Listing> GetAllListings(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

        public Listing? GetOneListing(int id, bool trackChanges)
        {
            return FindByCondition(l => l.ListingId == id, trackChanges).SingleOrDefault();
        }

        public void UpdateListing(Listing listing)=>UpdateListing(listing);
    }
}
