using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UretimPazari.Entities.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Navigation property
        public virtual User User { get; set; }
        public virtual ICollection<Offer> Offers { get; set; }
    }
}
