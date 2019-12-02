using System.ComponentModel.DataAnnotations;

namespace BondhumelaApp.Dtos {
    public class UserForLoginDto {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 4)]
        public string Password { get; set; }
    }
}