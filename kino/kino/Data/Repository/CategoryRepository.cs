using kino.Data.Interfaces;
using kino.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kino.Data.Repository
{
    public class CategoryRepository : IFilmsCategory
    {

        private readonly AppDBContent appDBContent; // переменная для работы с файлом фильмов

        public CategoryRepository(AppDBContent appDBContent) // конструктор по умолчанию принимающий следующий параметр
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Category> AllaCategories => appDBContent.Category; // получаем все категории
    }
}
