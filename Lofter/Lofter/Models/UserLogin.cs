using System.ComponentModel.DataAnnotations;

namespace Lofter.Models
{
    public class UserLogin
    {
        [Required(ErrorMessage = "This field is required.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string Password { get; set; }
    }
}