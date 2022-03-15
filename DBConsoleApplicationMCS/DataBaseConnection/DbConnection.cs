using Microsoft.EntityFrameworkCore;
using Models;

namespace DataBaseConnection
{
    public class DbConnection: DbContext
    {
        public DbSet<ActorModel> Actor { get; set; }
        public DbSet<CountryModel> Country { get; set; }
        public DbSet<CategoryModel> Category { get; set; }
        public DbSet<CityModel> City { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySQL("server=localhost;userid=root;pwd=rootmysql;port=3399;database=sakila;sslmode=none;");
        }
    }
    
}