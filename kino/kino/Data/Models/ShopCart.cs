using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kino.Data.Models
{
    public class ShopCart
    {
        private readonly AppDBContent appDBContent; // переменная для работы с файлом фильмов

        public ShopCart(AppDBContent appDBContent) // конструктор по умолчанию принимающий следующий параметр
        {
            this.appDBContent = appDBContent;
        }

        public string ShopCartId { get; set; }

        public List<ShopCartItems> listShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services) // функция, позволяющая определить добавлял ли пользователь этот товар уже в корзину, если добавлял добавляем его в туже корзину, если нет создаем новую корзину
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session; // создание новой сессии
            var context = services.GetService<AppDBContent>(); // получаем таблицу для работы с бд
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();// айди нашей корзины помещаем // ?? если не существует CartId то будем создавать новый идентификатор

            session.SetString("CartId", shopCartId); // когда взяли новое айди или установили его, мы устанавливаем

            return new ShopCart(context) { ShopCartId = shopCartId };

        }

        public void AddToCart(Films film, int amout) //функция позволяющая добавлять товары в корзину
        {
            appDBContent.ShopCartItems.Add(new ShopCartItems
            {
                ShopCartId = ShopCartId,
                film = film,
                price = film.price
            });

            appDBContent.SaveChanges();
        }

        public List<ShopCartItems> getShopItems()
        {
            return appDBContent.ShopCartItems.Where(c => c.ShopCartId == ShopCartId).Include(s => s.film).ToList();
        }
    }
}
