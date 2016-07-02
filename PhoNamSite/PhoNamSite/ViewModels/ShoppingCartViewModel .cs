using PhoNamSite.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhoNamSite.ViewModels
{
    public class ShoppingCartViewModel
    {
        [Key]
        public int CartId { get; set; }
        public List<Cart> CartItems { get; set; }
        public double CartTotal { get; set; }
    }
}