using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhoNamSite.Models
{
    public class DailySales
    {
        [Key]
        public int Id { get; set; }
        public int Day { get; set; }
        public string Date { get; set; }
        public double DailyTotal { get; set; }


    }
}