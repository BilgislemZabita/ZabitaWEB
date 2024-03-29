using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Linq;
using Zabita.Entities.Concrete;
using ZabitaWEB.Client.Services.Abstract;
using ZabitaWEB.Client.Services.Concrete;
using ZabitaWEB.Server.Concrete.EntityFramework;
using ZabitaWEB.Server.Extensions;

namespace ZabitaWEB.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            OperationalStoreOptions storeOptions = new OperationalStoreOptions
            {
                //populate needed members
            };
            IOptions<OperationalStoreOptions> operationalStoreOptions = Options.Create(storeOptions);

            DbContextOptions options = new DbContextOptionsBuilder<ZabitaDatabaseContext>()
                             .UseNpgsql("Host=localhost;Database=demirbaspersonelsarf;Username=postgres;Password=zabita2143")
                             .Options;
            //ZabitaDatabaseContext zabitaDatabaseContext = new ZabitaDatabaseContext(options, operationalStoreOptions);
            //zabitaDatabaseContext.Database.EnsureDeleted();
            //zabitaDatabaseContext.Database.EnsureCreated();
            // zabitaDatabaseContext.Database.Migrate();
            Configuration = configuration;

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();

            /* services.AddMvc(options => options.EnableEndpointRouting = false)
         .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);*/
            services.AddDbContext<DbContext>(options =>
            {
                options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));

            }, ServiceLifetime.Transient);
            services.AddDefaultIdentity<Personel>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<ZabitaDatabaseContext>().AddUserManager<CustomUserManager>();
            services.AddIdentityServer()
            .AddApiAuthorization<Personel, ZabitaDatabaseContext>((config) =>
            {
                config.Clients[0].AccessTokenLifetime = 3600;
            });
            services.AddAuthentication().AddIdentityServerJwt();

            services.AddAuthorization();





            services.AddTransient<ZabitaDatabaseContext>();
            services.AddControllersWithViews();

            services.AddRazorPages();
            services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

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

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseRouting();
            app.UseIdentityServer();

            app.UseAuthorization();




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