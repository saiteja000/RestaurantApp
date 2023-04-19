using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RestaurantApp.Models
{
    public class RestaurantMenu
    {
        [Key, Column(Order = 0)]
        public int Id { get; set; }

        [Key, Column(Order = 1)]
        public string MenuItem { get; set; }

        public string Description { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("RestaurantInfo")]
        public int RestaurantId { get; set; }
        public RestaurantInfo RestaurantInfo { get; set; }
    }
  
}