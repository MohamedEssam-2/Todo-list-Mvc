using Business_Logic_Layer.Profiles;

using Business_Logic_Layer.Services.Interface;
using Data_Access_Layer.Data.Context;

using Data_Access_Layer.Data.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace TodoList_App_Mvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<TodoDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddScoped<ITodoAppRepository, TodoAppRepository>();
            builder.Services.AddScoped<ITodoService,TodoService>();
            builder.Services.AddAutoMapper(m => m.AddProfile(new MappingProfile()));

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
                pattern: "{controller=Todo}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
