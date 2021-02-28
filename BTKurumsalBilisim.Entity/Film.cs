using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BTKurumsalBilisim.Entity
{
    public class Film
    {
        [Key]
        public int FilmId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Url { get; set; }

        public string PlayerDescription { get; set; }

        public string Description { get; set; }

        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }

        public List<FilmCategory> FilmCategories { get; set; }

    }
}
