using kino.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kino.ViewModels
{
    public class FilmsListViewModel
    {
        public IEnumerable<Films> allFilms { get; set; }

        public string currCategory { get; set; } // категория с которой мы работаем в данный момент
    }
}
