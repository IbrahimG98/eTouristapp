using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Description;
using AutoMapper;
using eTouristapp.Models.Request;
using eTouristapp.WebAPI.Database;
using eTouristapp.WebAPI.Security;
using eTouristapp.WebAPI.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.Swagger;
//using Swashbuckle.Swagger;

namespace eTouristapp.WebAPI
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
            services.AddControllers();
            services.AddMvc();
            // Register the Swagger generator, defining 1 or more Swagger documents
            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });

            //});

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });

                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header using the Bearer scheme."
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "basic"
                                }
                            },
                            new string[] {}
                    }
                });

            });





            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            //var connection = "Server=.;Database=eTourist1;Trusted_Connection=True;ConnectRetryCount=0"; //@Server nije podrzan
            //services.AddDbContext<eTourist1Context>(options => options.UseSqlServer(connection));


            var connection = Configuration.GetConnectionString("eTourist");
            services.AddDbContext<eTourist1Context>(options => options.UseSqlServer(connection));



            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<IPreporukaService, PreporukeService>();
            services.AddScoped<IService<Models.Grad, object>,BaseService<Models.Grad,object,Grad>>();
            services.AddScoped<IService<Models.Uloga, object>, BaseService<Models.Uloga, object,Uloga>>();
            services.AddScoped<ICRUDService<Models.Destinacija, DestinacijaSearchRequest,DestinacijaInsertRequest,DestinacijaInsertRequest>, DestinacijeService>();
            services.AddScoped<ICRUDService<Models.Hotel, HotelSearchRequest, HotelInsertRequest, HotelInsertRequest>, HoteliService>();
            services.AddScoped<ICRUDService<Models.Termin, TerminSearchRequest, TerminInsertRequest, TerminInsertRequest>, TerminiService>();
            services.AddScoped<ICRUDService<Models.Ocjena, OcjenaSearchRequest, OcjenaInsertRequest, OcjenaInsertRequest>, OcjeneService>();
            services.AddScoped<ICRUDService<Models.Karta, KartaSearchRequest, KartaInsertRequest, KartaInsertRequest>, KarteService>();
            services.AddScoped<ICRUDService<Models.Putnik, PutnikSearchRequest, PutnikInsertRequest, PutnikInsertRequest>, PutniciService>();
           
            services.AddAutoMapper(typeof(Startup));
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

           

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            //app.UseHttpsRedirection();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
