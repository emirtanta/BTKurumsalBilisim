using BTKurumsalBilisim.Business.Abstract;
using BTKurumsalBilisim.Entity;
using BTKurumsalBilisim.WebUI.Extensions;
using BTKurumsalBilisim.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTKurumsalBilisim.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private IFilmService _filmService;
        private ICategoryService _categoryService;

        public AdminController(IFilmService filmService, ICategoryService categoryService)
        {
            _filmService = filmService;
            _categoryService = categoryService;
        }

        #region Film CRUD Bölgesi


        #region Filmler Listesi Bölgesi

        public IActionResult FilmList()
        {
            return View(new FilmListModel()
            {
                Films = _filmService.GetAll()
            });
        }

        #endregion

        #region Film Ekleme Bölgesi

        public IActionResult FilmCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FilmCreate(FilmModel model)
        {
            var entity = new Film()
            {
                Name = model.Name,
                Url = model.Url,
                Description = model.Description,
                PlayerDescription = model.PlayerDescription,
                IsHome=model.IsHome,
                IsApproved=model.IsApproved

            };

            _filmService.Create(entity);

            //alert mesajları içerikleri
            TempData.Put("message", new AlertMessage()

            {
                Title = "Ürün eklendi",
                Message = $"{entity.Name} isimli film eklendi",
                AlertType = "success"
            });

            return RedirectToAction("FilmList", "Admin");
        }


        #endregion

        #region Film Güncelleme Bölgesi

        [HttpGet]
        public IActionResult FilmEdit(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }

            var entity = _filmService.GetByIdWithCategories((int)id);

            if (entity==null)
            {
                return NotFound();
            }

            var model = new FilmModel()
            {
                FilmId=entity.FilmId,
                Name=entity.Name,
                Url=entity.Url,
                PlayerDescription=entity.PlayerDescription,
                Description=entity.Description,
                IsApproved=entity.IsApproved,
                IsHome=entity.IsHome,
                SelectedCategories=entity.FilmCategories.Select(x=>x.Category).ToList()
            };

            ViewBag.Categories = _categoryService.GetAll();

            return View(model);
        }


        [HttpPost]
        public IActionResult FilmEdit(FilmModel model,int[] categoryIds)
        {
            var entity = _filmService.GetById(model.FilmId);

            if (entity == null)
            {
                return NotFound();
            }

            entity.Name = model.Name;
            entity.Url = model.Url;
            entity.IsApproved = model.IsApproved;
            entity.IsHome = model.IsHome;
            entity.PlayerDescription = model.PlayerDescription;
            entity.Description = model.Description;



            _filmService.Update(entity, categoryIds);

            //alert mesajları içerikleri
            TempData.Put("message", new AlertMessage()
            {
                Title = "Ürün Güncelleme",
                Message = $"{entity.Name} isimli film güncellendi",
                AlertType = "info"
            });

            return RedirectToAction("FilmList");
        }

        #endregion

        #region Film Silme Bölgesi


        public IActionResult FilmDelete(int filmId)
        {
            var entity = _filmService.GetById(filmId);

            if (entity != null)
            {
                _filmService.Delete(entity);
            }

            //alert mesajları içerikleri
            TempData.Put("message", new AlertMessage()
            {
                Title = "Film Silme",
                Message = $"{entity.Name} isimli film silindi",
                AlertType = "danger"
            });

            return RedirectToAction("FilmList", "Admin");
        }

        #endregion



        #endregion


        #region Kategori CRUD Bölgesi


        #region Kategori Listesi Bölgesi

        public IActionResult CategoryList()
        {
            return View(new CategoryListViewModels()
            {
                Categories = _categoryService.GetAll()
            }); ;
        }

        #endregion

        #region Kategori Ekleme Bölgesi

        [HttpGet]
        public IActionResult CategoryCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CategoryCreate(CategoryModel model)
        {
            var entity = new Category()
            {
                Name = model.Name,
                Url = model.Url
            };

            _categoryService.Create(entity);

            //alert mesajları içerikleri
            TempData.Put("message", new AlertMessage()
            {
                Title = "Kategori Ekleme",
                Message = $"{entity.Name} isimli kategori eklendi",
                AlertType = "success"
            });

            return RedirectToAction("CategoryList", "Admin");
        }

        #endregion

        #region Kategori Düzenleme Bölgesi

        [HttpGet]
        public IActionResult CategoryEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = _categoryService.GetByWithFilms((int)id);

            if (entity == null)
            {
                return NotFound();
            }

            var model = new CategoryModel()
            {
                CategoryId = entity.CategoryId,
                Name = entity.Name,
                Url = entity.Url,
                Films = entity.FilmCategories.Select(p => p.Film).ToList()
            };

            return View(model);

        }

        [HttpPost]
        public IActionResult CategoryEdit(int id, CategoryModel model)
        {
            var entity = _categoryService.GetById(model.CategoryId);

            if (entity == null)
            {
                return NotFound();
            }

            entity.Name = model.Name;
            entity.Url = model.Url;

            _categoryService.Update(entity);

            //alert mesajları içerikleri
            TempData.Put("message", new AlertMessage()
            {
                Title = "Kategori Gücelleme",
                Message = $"{entity.Name} isimli kategori güncellendi",
                AlertType = "info"
            });

            return RedirectToAction("CategoryList", "Admin");

        }

        #endregion

        #region Kategori Silme Bölgesi

        public IActionResult CategoryDelete(int categoryId)
        {
            var entity = _categoryService.GetById(categoryId);

            if (entity != null)
            {
                _categoryService.Delete(entity);
            }

            //alert mesajları içerikleri
            TempData.Put("message", new AlertMessage()
            {
                Title = "Kategori Silme",
                Message = $"{entity.Name} isimli kategori silindi",
                AlertType = "danger"
            });

            return RedirectToAction("CategoryList", "Admin");

        }

        #endregion

        #region Kategoriden Ürün Silme

        [HttpPost]
        public IActionResult DeleteFromCategory(int productId, int categoryId)
        {
            _categoryService.DeleteFromCategory(productId, categoryId);

            return Redirect("/admin/categories/" + categoryId);
        }

        #endregion

        #endregion


        
    }
}
