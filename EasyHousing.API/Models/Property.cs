using System;
using System.Collections.Generic;

#nullable disable

namespace EasyHousing.API.Models
{
    public partial class Property
    {
        public int PropertyId { get; set; }
        public string PropertyName { get; set; }
        public string PropertyType { get; set; }
        public string PropertyOption { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public decimal PriceRange { get; set; }
        public decimal InitialDeposit { get; set; }
        public string Landmark { get; set; }
        public string StateName { get; set; }
        public string CityName { get; set; }
        public int SellerId { get; set; }

        public virtual Seller Seller { get; set; }
    }
}
