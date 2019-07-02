using CarTestManager.Models;
using DatabaseLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class DBContext : IdentityDbContext<ApplicationUser>
    {
        public DBContext() : base("name=CarTestManagerDB") { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Test> Tests { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
