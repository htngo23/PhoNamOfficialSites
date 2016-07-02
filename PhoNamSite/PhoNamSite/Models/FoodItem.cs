using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhoNamSite.Models
{
    public class FoodItem
    {
        [Key]
        public int ID { get; set; }
        public string Food { get; set; }
        public int Quanity { get; set; }
        public string MeasurementType { get; set; }
        public string LatestPurchase { get; set; }
        public double ExpirationTime { get; set; }

    }
}