using System;
using System.Collections.Generic;

#nullable disable

namespace EasyHousing.API.Models
{
    public partial class Buyer
    {
        public int BuyerId { get; set; }
        public string BuyerUserame { get; set; }
        public string BuyerPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNo { get; set; }
        public string EmailId { get; set; }
    }
}
