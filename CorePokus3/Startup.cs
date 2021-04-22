using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CorePokus3.Database;
using CorePokus3.Entities;
using Microsoft.AspNetCore.Http;

namespace CorePokus3
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentity<User, AppRole>(options =>
            {
                options.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<LoginDbContext>();
            services.AddMvc();
            services.AddDbContext<LoginDbContext>(item => item.UseSqlServer(Configuration.GetConnectionString("myconn")));
            services.AddSession();
            services.AddAuthorization();
            
          //  services.ConfigureApplicationCookie(options =>
          //{
          //    options.LoginPath=("/Account/Login");

          //          //Promjena routa nakon linka 
          //  // options.Cookie.Name = "auth_cookie";
          //   //options.Cookie.SameSite = SameSiteMode.None;
          //  // options.LoginPath = new PathString("/Employee/Index");
          //   //options.AccessDeniedPath = new PathString("/Home/Login");
          // });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseCookiePolicy();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Login}/{id?}");
               
                //endpoints.MapRazorPages();
            });

        }
    }
}
