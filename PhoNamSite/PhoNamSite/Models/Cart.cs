using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhoNamSite.Models
{
    public class Cart
    {
        [Key]
        public int OrderId { get; set; }
        public string CartId { get; set; }
        public int Count { get; set;}
        public int ProductId { get; set; }
        public System.DateTime DateCreated { get; set; }
        public virtual MenuProduct MenuProduct { get; set; }



    }
}