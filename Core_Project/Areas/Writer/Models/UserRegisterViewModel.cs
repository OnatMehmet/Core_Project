using System.ComponentModel.DataAnnotations;

namespace Core_Project.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen ad girin")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Lütfen soyadı girin")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Lütfen Rsim URL girin")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Lütfen Kullanıcı adı girin")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Şifre  girin")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi tekrar  girin")]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen Mail girin")]
        public string Mail { get; set; }

    }
}
