using BtKurumsalBilisim.Data.Abstract;
using BTKurumsalBilisim.Business.Abstract;
using BTKurumsalBilisim.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BTKurumsalBilisim.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void Create(Category entity)
        {
            _categoryRepository.Create(entity);
        }

        public void Delete(Category entity)
        {
            _categoryRepository.Delete(entity);
        }

        public void DeleteFromCategory(int categoryId, int filmId)
        {
            _categoryRepository.DeleteFromCategory(filmId,categoryId);
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public Category GetByWithFilms(int id)
        {
            return _categoryRepository.GetByWithFilms(id);
        }

        public void Update(Category entity)
        {
            _categoryRepository.Update(entity);
        }
    }
}
