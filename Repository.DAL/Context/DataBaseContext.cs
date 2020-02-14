using System;
using EntityRepository;
using Microsoft.EntityFrameworkCore;

namespace Repository.DAL.Context
{
    public class DataBaseContext : DbContext
    {
        //public DataBaseContext(DbContextOptions<DataBaseContext> options)
        //    : base(options)
        //{ }
        public DataBaseContext() {}
            public DbSet<Cliente> Clientes { get; set; }
    }
}
