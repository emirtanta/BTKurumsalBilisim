using BTKurumsalBilisim.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BtKurumsalBilisim.Data.Abstract
{
    public interface ICategoryRepository:IRepository<Category>
    {
        List<Category> GetPopularCategories();

        //kategoriye ait filmleri getirir
        Category GetByWithFilms(int categoryId);

        void DeleteFromCategory(int filmId, int categoryId);
    }
}
