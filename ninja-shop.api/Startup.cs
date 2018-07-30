using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Cors.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ninja_shop.api.InMemoryInfrastructure;
using ninja_shop.api.Services;
using Newtonsoft.Json.Serialization;
using ninja_shop.api.DatabaseInfrastructure;
using Microsoft.EntityFrameworkCore;

namespace ninja_shop.api
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

            services.AddCors(o => o.AddPolicy("openPipe", builder =>
            {
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            }));
            
            services.AddMvc()
                .AddJsonOptions(options =>
                {
                    options.SerializerSettings.ContractResolver =
                        new CamelCasePropertyNamesContractResolver();
                });
            services.Configure<MvcOptions>(options =>
            {
                options.Filters.Add(new CorsAuthorizationFilterFactory("openPipe"));
            });

            services.AddDbContext<NinjaShopContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("NinjaShop")));

            services.AddScoped<IDataContext, DatabaseStorage>();
            
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICustomerRepository, DatabaseCustomerRepository>();
            services.AddScoped<IOrderRepository, DatabaseOrderRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
