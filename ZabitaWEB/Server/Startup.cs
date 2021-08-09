using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
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
using System.Text;
using Zabita.Entities.Abstract;
using Zabita.Entities.Concrete;
using ZabitaWEB.Client.Services.Abstract;
using ZabitaWEB.Client.Services.Concrete;
using ZabitaWEB.Server.Concrete.EntityFramework;

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
           // ZabitaDatabaseContext zabitaDatabaseContext = new ZabitaDatabaseContext(options, operationalStoreOptions);
           // zabitaDatabaseContext.Database.EnsureDeleted();
           // zabitaDatabaseContext.Database.EnsureCreated();
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
            // services.AddDefaultIdentity<Personel>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<ZabitaDatabaseContext>();
            //services.AddIdentityServer()
            //.AddApiAuthorization<Personel, ZabitaDatabaseContext>((config) =>
            //{
            //    config.Clients[0].AccessTokenLifetime = 3600;

            //});
            services.AddTransient<IZabitaDatabaseContext, ZabitaDatabaseContext>();
            var key = Encoding.ASCII.GetBytes("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJ6YWJpdGFkYnNlcnZpY2V1c2VyIiwianRpIjoiM2QxYjQ3MmItNmMwNy00NTc1LWE5NGMtNGQ2NDI5ZGIwNzg1IiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoibGRhcCIsIm5iZiI6MTYyODQ5MjI5NCwiZXhwIjoxNjMxMDg0Mjk0LCJpc3MiOiJkZGQiLCJhdWQiOiJzZGZkc2ZkcyJ9.JU6gyuqCET6kV3y5WVJSQPChgXHJKVQHwp5wWw3KgTc");
            //services.AddAuthentication().AddIdentityServerJwt();
            services.AddAuthentication( )
        .AddJwtBearer(options => {
            options.Audience = "http://localhost:5000/";
            options.Authority = "https://gauservices.ibb.gov.tr/api/LDAP/ValidateUser";
        });
            //services.AddAuthentication(cfg =>
            //{
            //    cfg.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    cfg.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //})
            //    .AddJwtBearer( o => o.TokenValidationParameters = new TokenValidationParameters
            //{
            //    ValidIssuer = "https://gauservices.ibb.gov.tr/api/LDAP/ValidateUser",
            //    IssuerSigningKey = new SymmetricSecurityKey(key),
            //    ValidateAudience = false,
            //    ValidateIssuer = false
            //});
    //        services.Configure<JwtBearerOptions>(
    //IdentityServerJwtConstants.IdentityServerJwtBearerScheme,
    //options =>
    //{
    //    options.Authority = "https://gauservices.ibb.gov.tr/api/LDAP/ValidateUser";
    //});




            //services.AddTransient<ZabitaDatabaseContext>();
            services.AddControllersWithViews();

            services.AddRazorPages();
            //services.Configure<IdentityOptions>(options =>
            //{
            //    // Password settings.
            //    options.Password.RequireDigit = true;
            //    options.Password.RequireLowercase = true;
            //    options.Password.RequireNonAlphanumeric = true;
            //    options.Password.RequireUppercase = true;
            //    options.Password.RequiredLength = 6;
            //    options.Password.RequiredUniqueChars = 1;

            //    // Lockout settings.
            //    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
            //    options.Lockout.MaxFailedAccessAttempts = 5;
            //    options.Lockout.AllowedForNewUsers = true;

            //    // User settings.
            //    options.User.AllowedUserNameCharacters =
            //    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
            //    options.User.RequireUniqueEmail = false;
            //});

            //services.ConfigureApplicationCookie(options =>
            //{
            //    // Cookie settings
            //    options.Cookie.HttpOnly = true;
            //    options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

            //    options.LoginPath = "/Identity/Account/Login";
            //    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
            //    options.SlidingExpiration = true;
            //});
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

         //   app.UseIdentityServer();

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
