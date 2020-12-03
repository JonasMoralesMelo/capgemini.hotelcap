using HotelTDD.Domain.Interface;
using HotelTDD.Infra.Context;
using HotelTDD.Repository;
using HotelTDD.Services.ClientService;
using HotelTDD.Services.Interface;
using HotelTDD.Services.Invoice;
using HotelTDD.Services.Occupation;
using HotelTDD.Services.Room;
using HotelTDD.Services.TypeRoom;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace HotelTDD
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = Configuration.GetConnectionString("HotelDB");

            services.AddDbContext<HotelContext>(options => options.UseSqlServer(connectionString));          
            services.AddScoped<IRoomService, RoomService>();
            services.AddScoped<ITypeRoomService, TypeRoomService>();
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IOccupationService, OccupationService>();
            services.AddScoped<IInvoiceService, InvoiceService>();

            services.AddScoped<IRoomRepository, RoomRepository>();
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<ITypeRoomRepository, TypeRoomRepository>();
            services.AddScoped<IOccupationRepository, OccupationRepository>();

            services.AddCors();
            services.AddControllers();

            var key = Encoding.ASCII.GetBytes(HotelTDD_New.Settings.Secret);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });


            services.AddControllers();
            services.AddSwaggerGen();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Hotel API");
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
