using BTKurumsalBilisim.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BtKurumsalBilisim.Data.Abstract
{
    public interface IFilmRepository:IRepository<Film>
    {
        Film GetFilmDetails(string url);

        List<Film> GetFilmsByCategory(string name, int page, int pageSize);

        List<Film> GetPopularFilms();

        List<Film> GetSearchResult(string searchString);

        List<Film> GetHomePageFilms();

        int GetCountByCategory(string category);

        Film GetByIdWithCategories(int id);
        void Update(Film entity, int[] categoryIds);
    }
}
