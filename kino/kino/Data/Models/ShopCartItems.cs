using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kino.Data.Models
{
    public class ShopCartItems
    {
        public int id { get; set; }  // айди самого товара
        public Films film { get; set; } // конкретно сам объект
        public int price { get; set; } //цена
        public string ShopCartId { get; set; } // айди товара внутри корзины
    }
}
