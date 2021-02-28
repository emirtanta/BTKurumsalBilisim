using System;
using System.Collections.Generic;
using System.Text;

namespace BTKurumsalBilisim.Entity
{
    public class FilmCategory
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }


        public int FilmId { get; set; }
        public Film Film { get; set; }
    }
}
