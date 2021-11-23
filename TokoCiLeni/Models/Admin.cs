using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TokoCiLeni.Models
{
    public partial class Admin
    {
        public Admin()
        {
            Seller = new HashSet<Seller>();
        }

        public int IdAdmin { get; set; }
        public string AdminName { get; set; }
        public int? IdCustomer { get; set; }

        public virtual ICollection<Seller> Seller { get; set; }
    }
}
