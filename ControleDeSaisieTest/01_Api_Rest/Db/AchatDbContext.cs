using Microsoft.EntityFrameworkCore;

namespace _01_Api_Rest.Db
{
    public class AchatDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
