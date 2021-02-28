using BTKurumsalBilisim.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BTKurumsalBilisim.Business.Abstract
{
    public interface IFilmService
    {
        Film GetById(int id);

        Film GetByIdWithCategories(int id);

        Film GetByFilmDetails(string url);

        List<Film> GetByFilmsByCategory(string name, int page, int pageSize);

        List<Film> GetHomePageFilms();
        List<Film> GetSearchResult(string searchString);
        List<Film> GetAll();

        void Create(Film entity);

        void Update(Film entity);

        void Delete(Film entity);
        int GetCountByCategory(string category);


        void Update(Film entity, int[] categoryIds);
    }
}
