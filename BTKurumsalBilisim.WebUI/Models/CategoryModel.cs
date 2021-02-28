using BTKurumsalBilisim.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BTKurumsalBilisim.WebUI.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }

        [Display(Name = "Kategori Adı")]
        public string Name { get; set; }

        public string Url { get; set; }
        public List<Film> Films { get; set; }
    }
}
