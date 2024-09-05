using System.ComponentModel.DataAnnotations;

namespace Identity1_new.Models.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(50)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }


    }
}
