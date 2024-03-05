using InBazar.Domain.Entity.Products;
using InBazar.Domain.Entity.Users;
using InBazar.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InBazar.Service.IService
{
    public interface IUserService
    {
        IQueryable<User> GetAll(Expression<Func<User, bool>> expression, string[] includes = null);
        ValueTask<UserDto> GetAsync(Expression<Func<User, bool>> expression, string[] includes = null);
        ValueTask<UserDto> CreateAsync(UserDto entity);
        ValueTask<bool> DeleteAsync(Expression<Func<User, bool>> expression);
        UserDto Update(int id, UserDto entity);
    }
}
