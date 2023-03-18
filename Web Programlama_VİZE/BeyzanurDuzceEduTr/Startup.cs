using BeyzanurDuzceEduTr.Controllers.Utility;
using BeyzanurDuzceEduTr.Models;
using BeyzanurDuzceEduTr.Models.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeyzanurDuzceEduTr
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<BeyzanurDuzceEduTrContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<Users, IdentityRole>().AddEntityFrameworkStores<BeyzanurDuzceEduTrContext>().AddDefaultTokenProviders();
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 5;
                options.Password.RequireNonAlphanumeric = false; //@ * gibi karakterler olmal�

                options.Lockout.MaxFailedAccessAttempts = 5; //5 giri�ten sonra kilitlenioyr. 
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMilliseconds(5); //5 dk sonra a��l�r
                options.Lockout.AllowedForNewUsers = true; //�sttekilerle alakal�

                options.User.RequireUniqueEmail = true; //unique emaail adresleri olsun her kullan�c�n�n 

                options.SignIn.RequireConfirmedEmail = false; //Kay�t olduktan email ile token g�nderecek 
                options.SignIn.RequireConfirmedPhoneNumber = false; //telefon do�rulamas�
            });
            services.ConfigureApplicationCookie(option => //cookie burada yarat�l�r.
            {
                option.LoginPath = "/Home/Login";
                option.LogoutPath = "/Home/logout";
                option.SlidingExpiration = true; //session s�resi 20 dk d�r 20 dk boyunca herhangi bir istek gelmezse oturum kapat�l�r. 
                option.ExpireTimeSpan = TimeSpan.FromMinutes(36); //36 dk'l�k bir session olu�tur.

                option.Cookie = new CookieBuilder
                {
                    HttpOnly = true, //cookie'yi sadece http olarak alabiliriz.
                    Name = ".BeyzanurDuzce.Security.Cookie",
                    SameSite = SameSiteMode.Strict //B kullan�c�s� An�n cookiesine sahip olsa bile onun ad�na i�lem ypaamz bunu yazarsak 
                };


            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            //app.UseAuthentication();
            //app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllers();
            //    endpoints.MapRazorPages();
            //});
        }
    }
}
