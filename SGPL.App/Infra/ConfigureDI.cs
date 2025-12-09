using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using SGPL.App.Others;
using SGPL.App.Register;
using SGPL.App.ViewModel;
using SGPL.App.ViewModels;
using SGPL.Domain.Base;
using SGPL.Domain.Entities;
using SGPL.Repository.Context;
using SGPL.Repository.Repository;
using SGPL.Service.Service;
using System;
using System.IO;

namespace SGPL.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection services;
        public static IServiceProvider? serviceProvider;

        public static void ConfigureServices()
        {
            var strCon = File.ReadAllText("Config/DBConfig.txt");
            services = new ServiceCollection();

            // DbContext
            services.AddDbContext<SGPLContext>(options =>
            {
                options.LogTo(Console.WriteLine);
                options.UseMySQL(strCon);
            });

            // Repositories
            services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
            services.AddScoped<IBaseRepository<Feed>, BaseRepository<Feed>>();
            services.AddScoped<IBaseRepository<Production>, BaseRepository<Production>>();
            services.AddScoped<IBaseRepository<Animal>, BaseRepository<Animal>>();
            services.AddScoped<IBaseRepository<Sale>, BaseRepository<Sale>>();
            services.AddScoped<IBaseRepository<SaleItem>, BaseRepository<SaleItem>>();

            // Services
            services.AddScoped<IBaseService<User>, BaseService<User>>();
            services.AddScoped<IBaseService<Feed>, BaseService<Feed>>();
            services.AddScoped<IBaseService<Production>, BaseService<Production>>();
            services.AddScoped<IBaseService<Animal>, BaseService<Animal>>();
            services.AddScoped<IBaseService<Sale>, BaseService<Sale>>();
            services.AddScoped<IBaseService<SaleItem>, BaseService<SaleItem>>();

            // Forms
            services.AddTransient<LoginForm>();
            services.AddTransient<UserForm>();
            services.AddTransient<FeedForm>();
            services.AddTransient<ProductionForm>();
            services.AddTransient<AnimalForm>();
            services.AddTransient<SaleForm>();
            services.AddTransient<MainForm>(sp =>
                new MainForm(
                    sp.GetRequiredService<IBaseService<User>>(),
                    sp
                )
            );

            // AutoMapper
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<User, UserViewModel>();
                config.CreateMap<Feed, FeedViewModel>();
                config.CreateMap<Production, ProductionViewModel>()
                      .ForMember(d => d.FeedId, opt => opt.MapFrom(src => src.Feed.Id))
                      .ForMember(d => d.FeedType, opt => opt.MapFrom(src => src.Feed.FeedType));
                config.CreateMap<Animal, AnimalViewModel>()
                      .ForMember(d => d.Production, opt => opt.MapFrom(src => src.Production.Product));
                config.CreateMap<Sale, SaleViewModel>()
                      .ForMember(d => d.IdSalesman, opt => opt.MapFrom(src => src.Salesman.Id))
                      .ForMember(d => d.Salesman, opt => opt.MapFrom(src => src.Salesman.Name));
                config.CreateMap<SaleItem, SaleItemViewModel>()
                      .ForMember(d => d.IdProduction, opt => opt.MapFrom(src => src.Production.Id))
                      .ForMember(d => d.Production, opt => opt.MapFrom(src => src.Production.Product));
            }, NullLoggerFactory.Instance).CreateMapper());

            serviceProvider = services.BuildServiceProvider();
        }
    }
}
