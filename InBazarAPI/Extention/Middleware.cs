﻿using InBazar.DataAcces.InBazarDBContext;
using InBazar.DataAcces.IRepository;
using InBazar.DataAcces.Repository;
using InBazar.Domain.Entity.Products;
using InBazar.Domain.Entity.Users;
using InBazar.Service.IService;
using InBazar.Service.Service;
using Microsoft.EntityFrameworkCore;

namespace InBazarAPI.Extention
{
    public static class Middleware
    {
        public static void AddDbConTextes(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(option =>
            option.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        }

        public static void AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IGenericRepository<User>, GenericRepository<User>>();
            services.AddTransient<IGenericRepository<Product>, GenericRepository<Product>>();
        }

        public static void AddService(this IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IUserService, UserService>();
        }
    }
}
