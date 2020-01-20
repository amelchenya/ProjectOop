using kino.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kino.Data.Interfaces
{
   public interface IFilmsCategory
    {
        IEnumerable<Category> AllaCategories { get; }//функция возвращающая категории
    }
}
