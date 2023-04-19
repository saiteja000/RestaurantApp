using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RestaurantApp.Models
{
    public class MenuItemType
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }

        [ForeignKey("RestaurantInfo")]
        public int RestaurantId { get; set; }
        public RestaurantInfo RestaurantInfo { get; set; }

        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}