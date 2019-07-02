using DatabaseLayer.Entities;
using System;
using System.Data.Entity;

namespace DatabaseLayer
{
    public class DBContext : DbContext
    {
        public DBContext() : base("name=CarTestManagerDB") { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Test> Tests { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
