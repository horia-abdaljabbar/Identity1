using System.ComponentModel.DataAnnotations;

namespace Identity1_new.Models.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(50)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(50)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

        public String Phone { set; get; }

    }
}
