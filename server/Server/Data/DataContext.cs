using Microsoft.EntityFrameworkCore;
namespace Server.Data
{
    public class DataContext : DbContext
    {
        /*public DataContext(string connString)
                 {
            
        }*/
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<SuperHero> SuperHeroes => Set<SuperHero>();
    }
}
