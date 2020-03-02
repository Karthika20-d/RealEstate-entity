using System.ComponentModel.DataAnnotations;

namespace OnlineRealEstate.Entity
{
    public class Property
    {
            [Required]
            [Key]
            public int LandId { get; set; }
            [Required]
            public string PropertyType { get; set; }
            [Required]
            public int Area { get; set; }
            [Required]
            public string Location { get; set; }
    }
}
