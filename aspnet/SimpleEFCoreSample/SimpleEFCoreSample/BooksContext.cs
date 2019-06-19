using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleEFCoreSample
{
    public class BooksContext : DbContext
    {
        private const string ConnectionString = @"server=(localdb)\mssqllocaldb;database=SkidataBooks1;trusted_connection=true";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().Property(b => b.Publisher).IsRequired(false).HasMaxLength(25);
        }

        public DbSet<Book> Books { get; set; }
    }
}
