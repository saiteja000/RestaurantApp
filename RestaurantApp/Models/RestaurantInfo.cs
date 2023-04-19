using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RestaurantApp.Models
{
    public class RestaurantInfo
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string zipcode { get; set; }
        public string phone { get; set; }
        public string website { get; set; }

        [ForeignKey("Cuisine")]
        public int CuisineId { get; set; }
        public Cuisine Cuisine { get; set; }
        public string rating { get; set; }
        public string pricerange { get; set; }

        

    }
}