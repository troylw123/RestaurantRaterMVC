using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantRaterMVC.Models.Restaurant
{
    public class RestaurantCreate
    {
        [Required]
        [MaxLength(100)]
        public string Name {get; set;}
        [Required]
        [MaxLength(100)]
        public string Location {get; set;}

    }
}