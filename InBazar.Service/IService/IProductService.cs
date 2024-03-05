﻿using InBazar.Domain.Entity.Products;
using InBazar.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InBazar.Service.IService
{
    public interface IProductService
    {
        IQueryable<Product> GetAll(Expression<Func<Product, bool>> expression, string[] includes = null);
        ValueTask<ProductDto> GetAsync(Expression<Func<Product, bool>> expression, string[] includes = null);
        ValueTask<ProductDto> CreateAsync(ProductDto entity);
        ValueTask<bool> DeleteAsync(Expression<Func<Product, bool>> expression);
        ProductDto Update(int id, ProductDto entity);
    }
}
