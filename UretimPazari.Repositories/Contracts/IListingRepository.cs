using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UretimPazari.Entities.Models;

namespace UretimPazari.Repositories.Contracts
{
    public interface IListingRepository:IRepositoryBase<Listing>
    {
        IEnumerable<Listing> GetAllListings(bool trackChanges);
        Listing? GetOneListing(int id, bool trackChanges);
        void CreateListing(Listing listing);
        void UpdateListing(Listing listing);
        void DeleteListing(Listing listing);
    }
}
