using System;

using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;

using System.Linq;

using System.Web;

 

namespace RestaurantApp.Models

{

    public class Cuisine

    {

        [Key]

        public int id { get; set; }

        public string name { get; set; }



        public string nutritionInfo { get; set; }



        public string texture { get; set; }



        public ICollection<RestaurantInfo> RestaurantInfos { get; set; }

    }

}





