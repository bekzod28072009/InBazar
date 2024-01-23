using InBazar.DataAcces.InBazarDBContext;
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
    }
}
