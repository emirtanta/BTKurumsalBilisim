using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BTKurumsalBilisim.WebUI.Models
{
    public class UserDetailsModel
    {
        public string UserId { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }

        [Display(Name = "Adınız")]
        public string FirstName { get; set; }

        [Display(Name = "Soyadınız")]
        public string LastName { get; set; }

        [Display(Name = "E-mail Adresiniz")]
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }

        //kullanıcı rollerini görmek için tanımlandı
        public IEnumerable<string> SelectedRoles { get; set; }
    }
}
