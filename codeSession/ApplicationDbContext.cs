using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace codeSession
{
    internal class ApplicationDbContext : DbContext
    {
        DbSet<Book> books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.;Initial Catalog=DataBasetest;Integrated Security=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>()
      .ToTable("Books3");

            modelBuilder.Entity<Book>().Property(d => d.DatePuplish).HasColumnName("Deadline");
            

        }
    }
}
