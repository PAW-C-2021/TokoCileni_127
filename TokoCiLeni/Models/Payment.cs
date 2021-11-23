using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TokoCiLeni.Models
{
    public partial class Payment
    {
        public Payment()
        {
            Item = new HashSet<Item>();
        }

        public int IdPayment { get; set; }
        public int? IdCustomer { get; set; }
        public int? IdSeller { get; set; }
        public string TotalPayment { get; set; }

        public virtual Customer IdCustomerNavigation { get; set; }
        public virtual Seller IdSellerNavigation { get; set; }
        public virtual ICollection<Item> Item { get; set; }
    }
}
