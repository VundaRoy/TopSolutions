using Fluent.Infrastructure.FluentModel;
using System.Collections.Generic;
using System.Data.Entity;
using TopSolutions.WebApi.Model;

namespace TopSolutions.WebApi.DAL
{
    public class TopSolDbContext : DbContext
    {
        public TopSolDbContext() : base("name=DefaultConnection")
        {
        }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure your model here if needed
            base.OnModelCreating(modelBuilder);
        }
    }
}
