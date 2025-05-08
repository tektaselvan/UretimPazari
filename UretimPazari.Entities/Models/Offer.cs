using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UretimPazari.Entities.Models
{
    public class Offer
    {
        public int OfferId { get; set; }
        public int ListingId { get; set; }
        public int SupplierId { get; set; }
        public decimal OfferAmount { get; set; }
        public string Status { get; set; } // 'Pending', 'Accepted', 'Rejected'
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Navigation properties
        public virtual Listing Listing { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
