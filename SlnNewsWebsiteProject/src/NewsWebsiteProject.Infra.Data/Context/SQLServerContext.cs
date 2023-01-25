using Microsoft.EntityFrameworkCore;
using NewsWebsiteProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsWebsiteProject.Infra.Data.Context
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions<SQLServerContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed
            modelBuilder.Entity<Category>()
                .HasData(
                    new { Id = 1, Name = "Programming"},
                    new { Id = 2, Name = "Gaming"},
                    new { Id = 3, Name = "Business"},
                    new { Id = 4, Name = "Sport"},
                    new { Id = 5, Name = "Entertainment" }
                );
        }

        #region DbSets
        public DbSet<Category> Category { get; set; }
        public DbSet<News> News { get; set; }
        #endregion
    }
}
