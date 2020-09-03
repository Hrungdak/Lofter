using System.ComponentModel.DataAnnotations;

namespace Lofter.Models
{
    public class TenantModel
    {
        public int TenantID { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string EmailAddress { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string ErrorMessage { get; set; }
    }
}