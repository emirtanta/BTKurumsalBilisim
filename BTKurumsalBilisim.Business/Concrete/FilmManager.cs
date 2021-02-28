using BtKurumsalBilisim.Data.Abstract;
using BTKurumsalBilisim.Business.Abstract;
using BTKurumsalBilisim.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BTKurumsalBilisim.Business.Concrete
{
    public class FilmManager : IFilmService
    {
        private IFilmRepository _filmRepository;
        public FilmManager(IFilmRepository filmRepository)
        {
            _filmRepository = filmRepository;
        }

        public void Create(Film entity)
        {
            _filmRepository.Create(entity);
        }

        public void Delete(Film entity)
        {
            _filmRepository.Delete(entity);
        }

        public List<Film> GetAll()
        {
            return _filmRepository.GetAll();
        }

        public Film GetByFilmDetails(string url)
        {
            return _filmRepository.GetFilmDetails(url);
        }

        public List<Film> GetByFilmsByCategory(string name, int page, int pageSize)
        {
            return _filmRepository.GetFilmsByCategory(name, page = 1, pageSize);
        }

        public Film GetById(int id)
        {
            return _filmRepository.GetById(id);
        }

        public Film GetByIdWithCategories(int id)
        {
            return _filmRepository.GetByIdWithCategories(id);
        }

        public int GetCountByCategory(string category)
        {
            return _filmRepository.GetCountByCategory(category);
        }

        public List<Film> GetHomePageFilms()
        {
            return _filmRepository.GetHomePageFilms();
        }

        public List<Film> GetSearchResult(string searchString)
        {
            return _filmRepository.GetSearchResult(searchString);
        }

        public void Update(Film entity)
        {
            _filmRepository.Update(entity);
        }

        public void Update(Film entity, int[] categoryIds)
        {
            _filmRepository.Update(entity, categoryIds);
        }
    }
}
