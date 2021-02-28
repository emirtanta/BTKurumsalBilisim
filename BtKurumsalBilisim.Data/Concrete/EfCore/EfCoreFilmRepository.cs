using BtKurumsalBilisim.Data.Abstract;
using BTKurumsalBilisim.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BtKurumsalBilisim.Data.Concrete.EfCore
{
    public class EfCoreFilmRepository : EfCoreGenericRepository<Film, FilmContext>, IFilmRepository
    {
        public Film GetByIdWithCategories(int id)
        {
            using (var context = new FilmContext())
            {
                return context.Films
                    .Where(i => i.FilmId == id)
                    .Include(i => i.FilmCategories)
                    .ThenInclude(i => i.Category)
                    .FirstOrDefault();
            }
        }

        public int GetCountByCategory(string category)
        {
            using (var context = new FilmContext())
            {
                //asqueryable yazılmasının sebebi linq sorgusunun yazılabilmesidir
                var films = context.Films.Where(i => i.IsApproved).AsQueryable();

                if (string.IsNullOrEmpty(category))
                {
                    //ürünü kategorisne göre filtreledik
                    films = films
                        .Include(i => i.FilmCategories)
                        .ThenInclude(i => i.Category)
                        .Where(i => i.FilmCategories.Any(a => a.Category.Url == category));

                }

                //skip metotdu sayfalama da ürün göstermek için tanımladık
                return films.Count();
            }
        }

        public List<Film> GetHomePageFilms()
        {
            using (var context = new FilmContext())
            {
                return context.Films.Where(i => i.IsApproved && i.IsHome == true).ToList();
            }
        }

        public List<Film> GetPopularFilms()
        {
            using (var context = new FilmContext())
            {
                return context.Films.ToList();
            }
        }

        public Film GetFilmDetails(string url)
        {
            using (var context = new FilmContext())
            {
                return context.Films
                    .Where(i => i.Url == url)
                    .Include(i => i.FilmCategories)
                    .ThenInclude(i => i.Category)
                    .FirstOrDefault();
            }
        }


        public List<Film> GetFilmsByCategory(string name, int page, int pageSize)
        {
            using (var context = new FilmContext())
            {
                //asqueryable yazılmasının sebebi linq sorgusunun yazılabilmesidir
                var films = context
                .Films
                .Where(i => i.IsApproved)
                .AsQueryable();

                if (string.IsNullOrEmpty(name))
                {
                    //ürünü kategorisne göre filtreledik
                    films = films
                        .Include(i => i.FilmCategories)
                        .ThenInclude(i => i.Category)
                        .Where(i => i.FilmCategories.Any(a => a.Category.Url == name));

                }

                //skip metotdu sayfalama da ürün göstermek için tanımladık
                return films.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            }
        }

        public List<Film> GetSearchResult(string searchString)
        {
            using (var context = new FilmContext())
            {
                //asqueryable yazılmasının sebebi linq sorgusunun yazılabilmesidir
                var films = context
                .Films
                .Where(i => i.IsApproved && (i.Name.ToLower().Contains(searchString.ToLower()) || i.Description.Contains(searchString.ToLower())))
                .AsQueryable();



                //skip metotdu sayfalama da ürün göstermek için tanımladık
                return films.ToList();
            }
        }

        public List<Film> GetTop5Films()
        {
            throw new System.NotImplementedException();
        }

        public void Update(Film entity, int[] categoryIds)
        {
            using (var context = new FilmContext())
            {
                var film = context.Films
                    .Include(i => i.FilmCategories)
                    .FirstOrDefault(i => i.FilmId == entity.FilmId);

                if (film != null)
                {
                    film.Name = entity.Name;
                    film.PlayerDescription = entity.PlayerDescription;
                    film.Description = entity.Description;
                    film.Url = entity.Url;
                    film.IsApproved = entity.IsApproved;
                    film.IsHome = entity.IsHome;

                    film.FilmCategories = categoryIds.Select(catid => new FilmCategory()
                    {
                        FilmId = entity.FilmId,
                        CategoryId = catid
                    }).ToList();

                    context.SaveChanges();
                }
            }
        }
    }
}
