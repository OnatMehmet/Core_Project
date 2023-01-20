using System.ComponentModel.DataAnnotations;

namespace Core_Project.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="Kullanıcı Adı")]
        [Required(ErrorMessage ="Kullanıcı Adı Boş geçilemez")]
        public string UserName { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifre Boş geçilemez")]
        public string Password { get; set; }
    }
}
