using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhoNamSite.Models
{
    public partial class PlaceOrder
    {
        [Key]
        public int OrderId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public double Total { get; set; }
        public System.DateTime OrderDate { get; set; }
        public List<PlaceOrderDetail> OrderDetails { get; set; }
    }
}