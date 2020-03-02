using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineRealEstate.Models
{
    public class PropertyModel
    {
        [Required]
        public int LandId { get; set; }
        [Required]
        public string PropertyType { get; set; }
        [Required]
        public int Area { get; set; }
        [Required]
        public string Location { get; set; }
    }
}