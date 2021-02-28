using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BTKurumsalBilisim.WebUI.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage ="Ad alanı gereklidir")]
        [Display(Name ="Ad")]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="Soyad alanı gereklidir")]
        [Display(Name = "Soyad")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Kullanıcı adı boş olamaz")]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre")]
        public string Password { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Girilen şifreler uyuşmuyor")]
        [Display(Name = "Şifre Tekrarla")]
        public string RePassword { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-Posta")]
        public string Email { get; set; }
    }
}
