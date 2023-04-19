using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantApp.Models
{
    public class Zipcode
    {
        [Key]
        public int zipcode { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }
}