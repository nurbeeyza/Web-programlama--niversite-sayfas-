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
                options.Password.RequireNonAlphanumeric = false; //@ * gibi karakterler olmalý

                options.Lockout.MaxFailedAccessAttempts = 5; //5 giriþten sonra kilitlenioyr. 
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMilliseconds(5); //5 dk sonra açýlýr
                options.Lockout.AllowedForNewUsers = true; //üsttekilerle alakalý

                options.User.RequireUniqueEmail = true; //unique emaail adresleri olsun her kullanýcýnýn 

                options.SignIn.RequireConfirmedEmail = false; //Kayýt olduktan email ile token gönderecek 
                options.SignIn.RequireConfirmedPhoneNumber = false; //telefon doðrulamasý
            });
            services.ConfigureApplicationCookie(option => //cookie burada yaratýlýr.
            {
                option.LoginPath = "/Home/Login";
                option.LogoutPath = "/Home/logout";
                option.SlidingExpiration = true; //session süresi 20 dk dýr 20 dk boyunca herhangi bir istek gelmezse oturum kapatýlýr. 
                option.ExpireTimeSpan = TimeSpan.FromMinutes(36); //36 dk'lýk bir session oluþtur.

                option.Cookie = new CookieBuilder
                {
                    HttpOnly = true, //cookie'yi sadece http olarak alabiliriz.
                    Name = ".BeyzanurDuzce.Security.Cookie",
                    SameSite = SameSiteMode.Strict //B kullanýcýsý Anýn cookiesine sahip olsa bile onun adýna iþlem ypaamz bunu yazarsak 
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
