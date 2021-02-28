using BtKurumsalBilisim.Data.Abstract;
using BtKurumsalBilisim.Data.Concrete.EfCore;
using BTKurumsalBilisim.Business.Abstract;
using BTKurumsalBilisim.Business.Concrete;
using BTKurumsalBilisim.WebUI.EMailService;
using BTKurumsalBilisim.WebUI.Identity;
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

namespace BTKurumsalBilisim.WebUI
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //IdentityDb için sql yolu
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));

            //parola resetlemek için
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();

            //kullanici kayit olma ayarlari
            services.Configure<IdentityOptions>(options =>
            {
                //parola ayarlari
                options.Password.RequireDigit = true; //dijital karakter içermeli
                options.Password.RequireLowercase = true; //küçük harf içermeli
                options.Password.RequireUppercase = true; //büyük harf içermeli
                options.Password.RequiredLength = 6;//en az 6 karakterlik parola
                options.Password.RequireNonAlphanumeric = true;//alfa nümerik karakter içermeli

                //lokout kullanicinin hesabi kilitlendigindeki ayarlar
                options.Lockout.MaxFailedAccessAttempts = 5; //en fazla 5 kez parola yanliþ girme hakki
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);//5 dakika sonra çikiþ yaptirma (istege bagli)

                //user ayarlari
                //options.User.AllowedUserNameCharacters = ""; //username içerisinde olmasi gereken deðerleri ayarlar
                options.User.RequireUniqueEmail = true;//her kullanicinin kendine özgü bir email olmasi kurali
                options.SignIn.RequireConfirmedEmail = true;//kullanicinin hesabinin  maili ile onaylanmasini saglar(true olursa)

            });

            //cookie ayarlari
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = TimeSpan.FromDays(365);
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,

                    SameSite = SameSiteMode.Strict //csrf token için form güvenligni saglar
                };
            });


            services.AddScoped<IFilmRepository, EfCoreFilmRepository>();
            services.AddScoped<ICategoryRepository, EfCoreCategoryRepository>();

            //business katmaninin calisabilmesi icin tanimladim
            services.AddScoped<IFilmService, FilmManager>();
            services.AddScoped<ICategoryService, CategoryManager>();

            //email gönderme ayarlarý
            services.AddScoped<IEmailSender, SmtpEmailSender>(x =>

            new SmtpEmailSender(
                _configuration["EmailSender:Host"],
                _configuration.GetValue<int>("EmailSender:Port"),
                _configuration.GetValue<bool>("EmailSender:EnableSSL"),
                _configuration["EmailSender:UserName"],
                _configuration["EmailSender:Password"]
            ));

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
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

            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                //user edit için rota yolu
                endpoints.MapControllerRoute(
                    name: "useredit",
                    pattern: "user/{id?}",
                    defaults: new { controller = "Rols", action = "UserEdit" });

                //user list için rota yolu
                endpoints.MapControllerRoute(
                    name: "users",
                    pattern: "user/list",
                    defaults: new { controller = "Rols", action = "UserList" });

                //rol listesi için
                endpoints.MapControllerRoute(
                    name: "roles",
                    pattern: "{controller=Rols}/{action=RoleList}");

                //rol create için
                endpoints.MapControllerRoute(
                    name: "rolecreate",
                    pattern: "{controller=Rols}/{action=RoleCreate}",
                     defaults: new { controller = "Rols", action = "RoleCreate" });

                //rol edit için
                endpoints.MapControllerRoute(
                    name: "roleedit",
                    pattern: "role/{id?}",
                    defaults: new { controller = "Rols", action = "RolEdit" });

                //film ekleme rota yolu
                endpoints.MapControllerRoute(
                    name: "adminfilmcreate",
                    pattern: "admin/film/create",
                    defaults: new { controller = "Admin", action = "FilmCreate" }
                );

                //film güncelleme rota yolu
                endpoints.MapControllerRoute(
                    name: "adminfilmedit",
                    pattern: "admin/films/{id?}",
                    defaults: new { controller = "Admin", action = "FilmEdit" }
                );

                //kategori listesi rota yolu
                endpoints.MapControllerRoute(
                    name: "admincategories",
                    pattern: "admin/categories",
                    defaults: new { controller = "Admin", action = "CategoryList" }
                );

                //kategori ekleme rota yolu
                endpoints.MapControllerRoute(
                    name: "admincategorycreate",
                    pattern: "admin/categories/create",
                    defaults: new { controller = "Admin", action = "CategoryCreate" }
                );

                //kategori güncelleme rota yolu
                endpoints.MapControllerRoute(
                    name: "admincategoryedit",
                    pattern: "admin/categories/{id?}",
                    defaults: new { controller = "Admin", action = "CategoryEdit" }
                );


                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
