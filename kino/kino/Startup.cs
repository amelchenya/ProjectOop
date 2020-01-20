using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kino.Data;
using kino.Data.Interfaces;
using kino.Data.mocks;
using kino.Data.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace kino
{
    public class Startup
    {

        private IConfigurationRoot _confString;

        public Startup(IHostingEnvironment hostEnv) // конструтор для работы с базами данных
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build(); // получение строки из джсон файла. setbasepath начальный путь, addjsonfile с каким файлом работаем. build получение файла
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddMvc();
            services.AddTransient<IAllFilms, FilmRepository>(); // для объединения интерфейса и класса реализующего интерфейс
            services.AddTransient<IFilmsCategory, CategoryRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage(); // отображение страницы с ошибками
            app.UseStatusCodePages(); // отображение кода страниц
            app.UseStaticFiles(); // использование статических файлов для отображения сss хтмл
            app.UseMvcWithDefaultRoute(); // использования url адреса контроллера по умолчанию


            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
                DBObjects.Initial(content);
            }

        }
    }
}
