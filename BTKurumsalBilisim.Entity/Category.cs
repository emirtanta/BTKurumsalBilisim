using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BTKurumsalBilisim.Entity
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Url { get; set; }

        public List<FilmCategory> FilmCategories { get; set; }
    }
}
