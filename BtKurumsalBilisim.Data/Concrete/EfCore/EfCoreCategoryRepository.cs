using BtKurumsalBilisim.Data.Abstract;
using BTKurumsalBilisim.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BtKurumsalBilisim.Data.Concrete.EfCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category, FilmContext>, ICategoryRepository
    {
        public void DeleteFromCategory(int filmId, int categoryId)
        {
            using (var context=new FilmContext())
            {
                var cmd = "delete from filmcategory where FilmId=@p0 and CategoryId=@p1";

                context.Database.ExecuteSqlRaw(cmd, filmId, categoryId);
            }
        }

        public Category GetByWithFilms(int categoryId)
        {
            using (var context=new FilmContext())
            {
                return context.Categories
                    .Where(i => i.CategoryId == categoryId)
                    .Include(i => i.FilmCategories)
                    .ThenInclude(i => i.Film)
                    .FirstOrDefault();
            }
        }

        public List<Category> GetPopularCategories()
        {
            throw new NotImplementedException();
        }
    }
}
