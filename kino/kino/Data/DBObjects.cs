﻿using kino.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kino.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value)); // из функции категорис берем все объекты и записываем их в качестве всех необходимых категорий

            if (!content.Film.Any())
            {
                content.AddRange(
                    new Films
                    {
                        name = "Джокер",
                        shortDesk = "История одного клоуна",
                        longDesk = "Артур Флек, скромный и незаметный человек, возвращается в Готэм после продолжительного отсутствия. Неудачливый комик планирует поухаживать за стареющей матерью, перевести дыхание и попытаться вновь запустить свою карьеру юмориста. Его мало волнует, что происходит вокруг. Но в прошлом Артура скрыт секрет: история Флеков каким-то образом связана с Уэйнами, богатейшей семьей Готэма. В конечном итоге эта тайна заставит Артура отбросить цивилизованный облик и принять новую роль — Клоуна, короля преступного мира.",
                        img = "/img/djoker.jpg",
                        price = 8,
                        isFavourite = true,
                        available = false,
                        Category = Categories["Драма"]
                    },
                    new Films
                    {
                        name = "Семейка Адамс",
                        shortDesk = "Думаете, ваша семейка странная?",
                        longDesk = "Папа любит долгие прогулки в ненастную погоду. Мама считает, что черный цвет самый яркий. У детей кладбище — любимая площадка для игр. Бабушка выпивает пару капель яда перед сном. Вы все еще думаете, что ваши родственники странные? Знакомьтесь — семейка Аддамс.",
                        img = "/img/adams.jpg",
                        price = 6,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Комедии"]
                    },
                    new Films
                    {
                        name = "Терминатор: Темные судьбы",
                        shortDesk = "Бессменный Шварценеггер вернулся",
                        longDesk = "Сара Коннор превратилась в настоящую охотницу за терминаторами и теперь занимается уничтожением роботов-убийц из будущего. Она считала, что главное — это не дать им добраться до Джона, но теперь появилась Дани Рамос, от выживания которой также зависит судьба человечества. Вместе с ней в бой вступает и загадочная Грейс, смесь человека и машины.",
                        img = "/img/terminator.jpg",
                        price = 8,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Фантастика"]
                    },
                    new Films
                    {
                        name = "Верность",
                        shortDesk = "Самая откровенная драма в российском кинематографе",
                        longDesk = "Лена — талантливая акушер-гинеколог, её муж Серёжа — артист провинциального драмтеатра. Близость и нежность у них есть, секса — нет. Лена подозревает, что Серёжа завёл роман на стороне, но она мучается молча и не выдаёт свою ревность. Вместо того чтобы выяснить отношения с мужем, Лена сама начинает изменять ему со случайными мужчинами. Она, конечно, не думала, что её параллельная жизнь окажется не менее подлинной, чем основная. И не менее реальной. И настолько опасной.",
                        img = "/img/forever.jpg",
                        price = 7,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Драма"]
                    },
                    new Films
                    {
                        name = "Короткий метр",
                        shortDesk = "Короткометражки для любителей хоррора",
                        longDesk = "Международный фестиваль короткометражных фильмов KINOSMENA и VOKA cinema представляют подборку фильмов специально для любителей жанра хоррор. Только те фильмы, которые действительно стоит смотреть!",
                        img = "/img/metr.jpg",
                        price = 6,
                        isFavourite = false,
                        available = false,
                        Category = Categories["Ужасы"]
                    },
                    new Films
                    {
                        name = "Свидетели Путина",
                        shortDesk = "Об этом невозможно молчать...",
                        longDesk = "События фильма начинаются 31 декабря 1999 года, когда россиянам представили их нового президента. Фильм основан на уникальных и строго документальных свидетельствах истинных причин и последствий смены лидера страны. Главными героями фильма являются Михаил Горбачев, Борис Ельцин, Владимир Путин и русский народ, а также сам автор, который предлагает нам серьезный и глубокий разговор о природе власти.",
                        img = "/img/putin.jpg",
                        price = 4,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Документальные"]
                    }
                );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)  // заполнена ли переменная категори
                {
                    var list = new Category[] //если она пустая мы помещаем в новый список нужные категории
                    {
                        new Category{ name = "Фантастика", desk = "Уйдите от реальности, погрузитесь в мир невозможного!"},
                        new Category{ name = "Комедии", desk = "Устали от ежедневной рутины? Надоела суета на работе? Найдите фильм, которые поднимет ваше настроение, смех от которого увеличит жизнь хотя бы на 1 час"},
                        new Category{ name = "Ужасы", desk = "Рискните, если смелые!"},
                        new Category{ name = "Драма", desk = "Найдите здесь свою жизнь"},
                        new Category{ name = "Документальные", desk = "Если вы умный, а хотите стать еще умнее, вам сюда!"}
                    };

                    category = new Dictionary<string, Category>(); // выделение памяти
                    foreach (Category el in list) // перебираем элементы списка через цикл
                        category.Add(el.name, el); // добавляем их внутрь списка category / Ключ - имя категории, значение - сам объект
                }

                return category; 
            }
        }
    }
}
