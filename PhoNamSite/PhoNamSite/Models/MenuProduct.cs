using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PhoNamSite.Models
{
    public class MenuProduct
    {
        [Key]
        public int ProductID { get; set; }

        public string MenuID { get; set; }

        [Required, Display(Name = "Name")]
        public string ProductName { get; set; }

        [Display(Name = "Product Description")]
        public string Description { get; set; }

        [Display(Name = "Price")]
        public double UnitPrice { get; set; }
        public string ImagePath { get; set; }

        public int? CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }


    }
}