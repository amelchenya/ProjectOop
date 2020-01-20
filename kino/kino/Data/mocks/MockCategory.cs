using kino.Data.Interfaces;
using kino.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kino.Data.mocks
{
    public class MockCategory : IFilmsCategory { // класс, реализующий интерфейс для работы с категорияими
        public IEnumerable<Category> AllaCategories // на основе модели Category
        {
            get
            {
                return new List<Category>
                {
                    new Category{ name = "Фантастика", desk = "Уйдите от реальности, погрузитесь в мир невозможного!", id = 0 },
                    new Category{ name = "Комедии", desk = "Устали от ежедневной рутины? Надоела суета на работе? Найдите фильм, которые поднимет ваше настроение, смех от которого увеличит жизнь хотя бы на 1 час", id = 1},
                    new Category{ name = "Ужасы", desk = "Рискните, если смелые!", id = 2},
                    new Category{ name = "Драма", desk = "Найдите здесь свою жизнь", id = 3},
                    new Category{ name = "Документальные", desk = "Если вы умный, а хотите стать еще умнее, вам сюда!", id = 4}
                };
            }
        }
    }
}
