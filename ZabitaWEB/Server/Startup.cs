using Microsoft.AspNetCore.Authentication;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;
using Zabita.DataAccessLayer.Concrete.EntityFramework;
using Zabita.Entities.Concrete;
using ZabitaWEB.Client.Services.Abstract;
using ZabitaWEB.Client.Services.Concrete;

namespace ZabitaWEB.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            //ZabitaDatabaseContext zabitaDatabaseContext = new ZabitaDatabaseContext();
            // zabitaDatabaseContext.Database.EnsureDeleted();
            //zabitaDatabaseContext.Database.EnsureCreated();
            // zabitaDatabaseContext.Database.Migrate();
            Configuration = configuration;

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            /* services.AddMvc(options => options.EnableEndpointRouting = false)
         .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);*/
            services.AddDbContext<DbContext>(options =>
            {
                options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));

            }, ServiceLifetime.Transient);
            services.AddDefaultIdentity<Personel>(options =>
        options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ZabitaDatabaseContext>();
            services.AddIdentityServer()
                .AddApiAuthorization<Personel, ZabitaDatabaseContext>();
            services.AddAuthentication().AddIdentityServerJwt();
            services.AddTransient<ZabitaDatabaseContext>();
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseRouting();

            app.UseIdentityServer();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            //app.UseMvcWithDefaultRoute();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
