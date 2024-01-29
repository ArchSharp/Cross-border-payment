using System.ComponentModel.DataAnnotations;

namespace Identity.Data.Dtos.Request.Account
{
    public class ChangePassword
    {
        [Required(ErrorMessage = "Password is required")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[#$^+=!*()@%&]).{8,}$", ErrorMessage = "Password must be minimum of 8 characters, least one number, least one uppercase, least one lowercase character and one special character")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[#$^+=!*()@%&]).{8,}$", ErrorMessage = "Password must be minimum of 8 characters, least one number, least one uppercase, least one lowercase character and one special character")]
        public string NewPassword { get; set; }
    }
}