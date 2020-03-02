using OnlineRealEstate.Entity;
using System.ComponentModel.DataAnnotations;
namespace OnlineRealEstate.Models
{
    
    public class SignUpModel
    {
        [Required(ErrorMessage = "Please enter your name")]
        [Display(Name = "Username")]
        [RegularExpression(@"^[A-Za-z]+$")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your mail")]
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Please enter valid mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        [Display(Name = "Phone Number")]
        [RegularExpression(@"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}", ErrorMessage = "Please enter your number")]
        public long PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please enter your password")]
        [Display(Name = "Password")]
        [RegularExpression("^(?=.{8,})(?=.*[a-z])(?=.*[A-Z])(?!.*s).*$", ErrorMessage = "Please enter valid password like uppercase,lowecase,symbol and number")]
        [MinLength(8, ErrorMessage = "Password should atleast contain 8 characters")]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Role")]
        public string Role { get; set; }
        [Required]
        [Display(Name = "Location")]
        public Location Location { get; set; }
    }
}