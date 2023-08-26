using System.ComponentModel.DataAnnotations;

namespace BookShop.Server.Features.Identity
{
    public class LoginRequestModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
