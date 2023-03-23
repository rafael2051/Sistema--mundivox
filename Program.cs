using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Sistema__mundivox.Data;
using Sistema__mundivox.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema__mundivox
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<BancoContext>(options => options.UseSqlServer
            ("Data Source=DESKTOP-OUBQ7OQ;Initial Catalog=Sistema_Mundivox_CRUD;User ID=sa;Password=123456;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True"));
            //("Data Source=DESKTOP-OUBQ7OQ;Initial Catalog=Sistema_Mundivox_Crud;Integrated Security=True"));

            builder.Services.AddScoped<IFornecedoresRepositorio, FornecedoresRepositorio>();
            builder.Services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
            builder.Services.AddScoped<IPedidosRepositorio, PedidosRepositorio>();
            builder.Services.AddScoped<IPedidosItensRepositorio, PedidosItensRepositorio>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}