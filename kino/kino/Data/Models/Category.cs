using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kino.Data.Models
{
    public class Category
    {
        public int id { set; get; } // уникальный id, и отправляем и принимаем

        public string name { set; get; } // имя категории

        public string desk { set; get; } // описание категории

        public List<Films> films{ set; get; } // список фильмов в категории
    }
}
