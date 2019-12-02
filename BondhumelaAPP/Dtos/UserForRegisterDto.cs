using System.ComponentModel.DataAnnotations;

namespace BondhuMela.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 4, ErrorMessage="You must specified password between 4 to 20.")]
        public string Password { get; set; }
    }
}