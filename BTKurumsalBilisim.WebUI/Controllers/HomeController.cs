using BTKurumsalBilisim.Business.Abstract;
using BTKurumsalBilisim.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BTKurumsalBilisim.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IFilmService _filmService;


        public HomeController(ILogger<HomeController> logger, IFilmService filmService)
        {
            _logger = logger;
            _filmService = filmService;
        }

        public IActionResult Index()
        {
            return View(new FilmListModel()
            {
                Films = _filmService.GetAll()
            });
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
