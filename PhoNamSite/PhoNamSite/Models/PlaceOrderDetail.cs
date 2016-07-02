using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhoNamSite.Models
{
    public class PlaceOrderDetail
    {
            [Key]
            public int OrderDetailId { get; set; }
            public int OrderId { get; set; }
            public int ProductId { get; set; }
            public int Quantity { get; set; }
            public double UnitPrice { get; set; }
            public virtual MenuProduct MenuProudct { get; set; }
            public virtual PlaceOrder PlaceOrder { get; set; }
        
    }
}
