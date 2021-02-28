using BTKurumsalBilisim.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BTKurumsalBilisim.WebUI.Models
{
    public class FilmModel
    {
        public int FilmId { get; set; }

        [Display(Name = "Film Adı", Prompt = "film adı")]
        public string Name { get; set; }

        public string Url { get; set; }

        [Required]
        [Display(Name ="Oyuncular",Prompt ="oyuncu adları")]
        [StringLength(10000, MinimumLength = 20, ErrorMessage = "Ürün açıklaması en az 20 en fazla 10000 karakter olabilir")]
        public string PlayerDescription { get; set; }


        [Required]
        [Display(Name = "Filmin Konusu",Prompt ="Açıklma metni yazın")]
        [StringLength(10000, MinimumLength = 20, ErrorMessage = "Ürün açıklaması en az 20 en fazla 10000 karakter olabilir")]
        public string Description { get; set; }

        [Display(Name = "Onaylı mı?")]
        public bool IsApproved { get; set; }

        [Display(Name = "Anasayfa Onayı")]
        public bool IsHome { get; set; }

        //ürün ile ilişkili kategorileri getirir
        public List<Category> SelectedCategories { get; set; }
    }
}
