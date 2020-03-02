using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineRealEstate.Entity
{
    public enum Location
    {
        Erode,
        Salem,
        Chennai,
        Bangalore,
        Hyderabad
    }
    public class User
    {
    
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Key]
        [Required]
        [MaxLength(30)]
        [Index(IsUnique = true)]
        public string Email { get; set; }
        [Required]
        public long PhoneNumber { get; set; }
        [Required]
        [MaxLength(20)]
        public string Password { get; set; }
        [Required]
        [MaxLength(10)]
        public string Role { get; set; }
        [Required]
        public Location Location { get; set; }
        public Property Property { get; set; }

    }
}
