using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TokoCiLeni.Models
{
    public partial class Seller
    {
        public Seller()
        {
            Payment = new HashSet<Payment>();
        }

        public int IdSeller { get; set; }
        public string SellerName { get; set; }
        public int? IdAdmin { get; set; }

        public virtual Admin IdAdminNavigation { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
    }
}
