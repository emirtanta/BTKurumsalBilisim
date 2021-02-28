using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BTKurumsalBilisim.WebUI.Models
{
    public class LoginModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string EMail { get; set; }


        public string ReturnUrl { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre")]
        public string Password { get; set; }
    }
}
