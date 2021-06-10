using Microsoft.EntityFrameworkCore;
using ApiWithJwtRefreshToken.Entities;

namespace ApiWithJwtRefreshToken.Helpers
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}