using BTKurumsalBilisim.Business.Abstract;
using BTKurumsalBilisim.Entity;
using BTKurumsalBilisim.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTKurumsalBilisim.WebUI.Controllers
{
    public class FilmController : Controller
    {
        private IFilmService _filmService;

        public FilmController(IFilmService filmService)
        {
            _filmService = filmService;
        }


        public IActionResult List(string category,int page=1)
        {
            //sayfada gösterilecek film sayısı
            const int pageSize = 2;

            return View(new FilmListModel()
            {
                Films = _filmService.GetByFilmsByCategory(category, page, pageSize),
                PagingInfo = new PagingInfo()
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = _filmService.GetCountByCategory(category),
                    CurrentCategory = category
                }
            });
        }

        public IActionResult Details(string url)
        {
            if (url == null)
            {
                return NotFound();
            }

            Film film = _filmService.GetByFilmDetails(url);

            if (film == null)
            {
                return NotFound();
            }

            return View(new FilmDetailModel
            {
                Film = film,
                Categories = film.FilmCategories.Select(i => i.Category).ToList()
            });
        }

        public IActionResult Search(string q)
        {
            var filmViewModel = new FilmListModel()
            {

                //Categories=categories,
                Films = _filmService.GetSearchResult(q)
            };

            //ViewModel ile iki modeli birleştirip gönderdik
            return View(filmViewModel);
        }
    }
}
