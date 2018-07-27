using System.ComponentModel.DataAnnotations;

namespace Inventory.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }    
        
        [Required]
        [StringLength(8, MinimumLength = 4, 
        ErrorMessage = "You must specify password between and 4 and 8 Charrecters")]
        public string Password { get; set; }
    }
}