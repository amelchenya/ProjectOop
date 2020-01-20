using kino.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kino.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) // базовый конструктор с базами данных
        {

        }

        public DbSet<Films> Film {get; set;} // функции для работы с фильмами и категориями в базе данных
        public DbSet<Category> Category { get; set; }
        public DbSet<ShopCartItems> ShopCartItems { get; set; }

    }
}
