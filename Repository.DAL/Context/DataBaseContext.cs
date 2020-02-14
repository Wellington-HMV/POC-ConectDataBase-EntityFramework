using EntityRepository;
using Microsoft.EntityFrameworkCore;

namespace Repository.DAL.Context
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() : base() { }
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
    }
}
