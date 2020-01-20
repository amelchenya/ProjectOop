using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kino.Data.Models
{
    public class Films
    {

        public int id { set; get; } // айди конкретного фильма

        public string name { set; get; } // имя фильма

        public string shortDesk { set; get; } // краткое описание фильма на главной странице

        public string longDesk { set; get; } // описание фильма на его странице

        public string img { set; get; } // для вкладывания url адреса для доступа к картинке

        public ushort price { set; get; } // цены на фильмы (только положительные)

        public bool isFavourite { set; get; } // будет отображаться на главной в блоке лучшие фильмы

        public bool available { set; get; } // есть ли в продаже билеты

        public int categoryId { set; get; } // номер фильма в данной категории

        public virtual Category Category { set; get; } // объект со всеми значениями в категории(к какой категории принадлежит фильм)
    }
}