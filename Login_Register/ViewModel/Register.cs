using System.ComponentModel.DataAnnotations;

namespace Login_Register.ViewModel
{
    public class Register
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Password Contain minimum of 6 digits.")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password),ErrorMessage ="Password and Confirm Password didn't Match")]
        public string ConfirmPassword { get; set; }
    }
}
