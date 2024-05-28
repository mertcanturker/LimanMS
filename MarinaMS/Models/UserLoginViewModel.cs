using System.ComponentModel.DataAnnotations;

namespace MarinaMS.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage ="Lütfen Sicil Giriniz.")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Lütfen Şifre Giriniz.")]
        public string Password { get; set; }
    }
}
