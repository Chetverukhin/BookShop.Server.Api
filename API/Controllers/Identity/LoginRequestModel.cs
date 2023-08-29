using System.ComponentModel.DataAnnotations;

namespace API.Controllers.Identity
{
    public class LoginRequestModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
