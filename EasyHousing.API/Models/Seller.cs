using System;
using System.Collections.Generic;

#nullable disable

namespace EasyHousing.API.Models
{
    public partial class Seller
    {
        public Seller()
        {
            Properties = new HashSet<Property>();
        }

        public int SellerId { get; set; }
        public string SellerUserName { get; set; }
        public string SellerPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateofBirth { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string EmailId { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}
