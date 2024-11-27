using System.ComponentModel.DataAnnotations;

namespace V2T.Models
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
