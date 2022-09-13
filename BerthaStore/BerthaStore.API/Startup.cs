using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using BerthaStore.Application.Mappings;
using BerthaStore.Core.Interfaces;
using BerthaStore.Infra.Repositories;
using BerthaStore.Application.UseCases;
using BerthaStore.Application.Models.NewOrder;
using BerthaStore.Application.Models.UpdateOrder;
using BerthaStore.Application.Models.SearchOrder;
using BerthaStore.Application.Models.NewClient;
using BerthaStore.Application.Models.UpdateClient;
using BerthaStore.Application.Models.SearchClient;
using BerthaStore.Application.Models.NewProduct;
using BerthaStore.Application.Models.UpdateProduct;
using BerthaStore.Application.Models.SearchProduct;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using BerthaStore.Infra.Database;

namespace BerthaStore.API
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
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IItemOrderRepository, ItemOrderRepository>();
            
            services.AddTransient<IUseCaseAsync<NewOrderRequest, IActionResult>, NewOrderUseCase>();
            //services.AddTransient<IUseCaseAsync<UpdateOrderRequest, IActionResult>, UpdateOrderUseCase>();
            //services.AddTransient<IUseCaseAsync<SearchOrderRequest, IActionResult>, SearchOrderUseCase>();

            //services.AddTransient<IUseCaseAsync<NewClientRequest, IActionResult>, NewClientUseCase>();
            //services.AddTransient<IUseCaseAsync<UpdateClientRequest, IActionResult>, UpdateClientUseCase>();
            //services.AddTransient<IUseCaseAsync<SearchClientRequest, IActionResult>, SearchClientUseCase>();

            services.AddTransient<IUseCaseAsync<NewProductRequest, IActionResult>, NewProductUseCase>();
            services.AddTransient<IUseCaseAsync<UpdateProductRequest, IActionResult>, UpdateProductUseCase>();
            services.AddTransient<IUseCaseAsync<SearchProductRequest, IActionResult>, SearchProductUseCase>();

            services.AddAutoMapper(typeof(MappingProfile));

            services.AddDbContext<ApplicationContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
            .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
            );

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BerthaStore.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApplicationContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BerthaStore.API v1"));
            }

            context.Database.Migrate();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
