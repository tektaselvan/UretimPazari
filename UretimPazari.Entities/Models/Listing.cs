using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UretimPazari.Entities.Models
{
    public class Listing
    {
        public int ListingId { get; set; }
        public int ProducerId { get; set; }
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; } = true; // true: Görünür, false: Gizli
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Navigation properties
        public virtual Producer Producer { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<Offer> Offers { get; set; }
    }
}
