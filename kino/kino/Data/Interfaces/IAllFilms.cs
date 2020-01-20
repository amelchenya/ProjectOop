using kino.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kino.Data.Interfaces
{
   public interface IAllFilms
    {
        IEnumerable<Films> AllFilms { get; } // возвращает все фильмы
        IEnumerable<Films> getFavFilms { get; } //возвращает лучшие фильмы
        Films getObjectFilm(int filmId); // возвращает определенный фильм  
    }
}
