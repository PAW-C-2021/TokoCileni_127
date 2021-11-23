using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TokoCiLeni.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Payment = new HashSet<Payment>();
        }

        public int IdCustomer { get; set; }
        public string CustomerName { get; set; }
        public string Alamat { get; set; }
        public string Telephone { get; set; }
        public int? IdItem { get; set; }

        public virtual Item IdItemNavigation { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
    }
}
