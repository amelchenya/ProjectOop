using kino.Data.Interfaces;
using kino.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kino.Data.Repository
{
    public class FilmRepository : IAllFilms // наследование
    {
        private readonly AppDBContent appDBContent; // переменная для работы с файлом фильмов

        public FilmRepository(AppDBContent appDBContent) // конструктор по умолчанию принимающий следующий параметр
        {
            this.appDBContent = appDBContent;
        }
        
        public IEnumerable<Films> AllFilms => appDBContent.Film.Include(c => c.Category); // метод расширения линкью для установки условий и получения ех нужных объектов из БД

        public IEnumerable<Films> getFavFilms => appDBContent.Film.Where(p => p.isFavourite).Include(c => c.Category); // получаем все объекты где isfavourite=true

        public Films getObjectFilm(int filmId) => appDBContent.Film.FirstOrDefault(p => p.id == filmId); // получаем тот фильм айди которого запрошен
    }
}
