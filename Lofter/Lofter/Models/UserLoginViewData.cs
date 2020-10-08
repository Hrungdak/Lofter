using Lofter.Contracts;
using System.ComponentModel.DataAnnotations;

namespace Lofter.Models
{
    public class UserLoginViewData : ITitle
    {
        public string Title { get; set; }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string ErrorMessage { get; set; }
    }
}