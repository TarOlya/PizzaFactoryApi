using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PizzaData;
using PizzaData.Interfaces;
using PizzaData.Models;
using PizzaData.Repositories;
using PizzaFactoryApi.Filters;
using PizzaFactoryApi.Validation;
using PizzaFactoryApi.ViewModels;
using Swashbuckle.AspNetCore.Swagger;

namespace PizzaFactoryApi
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
            services.AddMvc(options => { options.Filters.Add(new ExceptionFilter()); })
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddFluentValidation();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
            });
            services.AddDbContext<PizzaContext>(c => { c.UseNpgsql(Configuration.GetConnectionString("PizzaDb")); });
            services.AddTransient<IValidator<User>, UserModelValidator>();
            services.AddTransient<IValidator<PizzaModel>, PizzaModelValidator>();
            services.AddTransient<IValidator<IngredientModel>, IngredientModelValidator>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IPizzaRepository, PizzaRepository>();
            services.AddScoped<IIngredientRepository, IngredientRepository>();
            Mapper.Initialize(config =>
            {
                config.CreateMap<LoginParams, User>();
                config.CreateMap<IngredientModel, Ingredient>();
                config.CreateMap<PizzaModel, Pizza>();
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = "api";
            });
            app.UseAuthentication();
        }
    }
}
