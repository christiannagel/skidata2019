using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleEFCoreSample
{
    public class BooksContext : DbContext
    {
        public BooksContext(DbContextOptions<BooksContext> options)
            : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().Property(b => b.Publisher).IsRequired(false).HasMaxLength(25);
            // modelBuilder.Entity<Book>().Property(b => b.Publisher)
        }

        public DbSet<Book> Books { get; set; }
    }
}
