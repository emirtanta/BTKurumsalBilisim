using BTKurumsalBilisim.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BTKurumsalBilisim.Business.Abstract
{
    public interface ICategoryService
    {
        Category GetById(int id);

        Category GetByWithFilms(int id);

        List<Category> GetAll();

        void Create(Category entity);

        void Update(Category entity);

        void Delete(Category entity);

        void DeleteFromCategory(int categoryId, int filmId);

    }
}
