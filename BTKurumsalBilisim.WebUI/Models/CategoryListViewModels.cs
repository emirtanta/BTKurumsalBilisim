using BTKurumsalBilisim.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTKurumsalBilisim.WebUI.Models
{
    public class CategoryListViewModels
    {
        public string SelectedCategory { get; set; }
        public List<Category> Categories { get; set; }
    }
}
