using kino.Data.Interfaces;
using kino.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kino.Controllers
{
    public class FilmsController : Controller // здесь будут отображаться функции которые возвращают хтмл страницы
    {
        private readonly IAllFilms allFilms; // переменные на интерфейсы
        private readonly IFilmsCategory allCategories;

        public FilmsController(IAllFilms iAllFilms, IFilmsCategory iFilmsCat) // конструктор
        {
            allFilms = iAllFilms;
            allCategories = iFilmsCat;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Список фильмов";
            FilmsListViewModel obj = new FilmsListViewModel();
            obj.allFilms = allFilms.AllFilms;
            obj.currCategory = "Фильмы";

            return View(obj); // будущая хтмл страница

        }
    }
}
