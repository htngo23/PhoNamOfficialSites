using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PhoNamSite.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required, Display(Name = "Name")]
        public string CategoryName { get; set; }

        public virtual ICollection<MenuProduct> MenuProducts { get; set; }
    }
}