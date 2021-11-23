using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TokoCiLeni.Models
{
    public partial class Item
    {
        public Item()
        {
            Customer = new HashSet<Customer>();
        }

        public int IdItem { get; set; }
        public string ItemName { get; set; }
        public string ItemNumber { get; set; }
        public int? IdPayment { get; set; }

        public virtual Payment IdPaymentNavigation { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
    }
}
