using System;
using Microsoft.EntityFrameworkCore;

namespace SimpleEFCoreSample
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateTheDatabase();
            AddRecords();
            SqlInjection("wrox; drop table ..");
        }

        private static void SqlInjection(string publisher)
        {
            using (var context = new BooksContext())
            {
                context.Books.FromSql($"select * from books where publisher = {publisher}");  // no sql injection


                string sql = $"select * from books where publisher = {publisher}";
                var result = context.Books.FromSql(sql); // sql injection!!!

                FormattableString sql2 = $"select * from books where publisher = {publisher}";
                context.Books.FromSql(sql2); // no sql injection
            }
        }

        private static void AddRecords()
        {
            using var context = new BooksContext();
            var book = new Book { Title = "Professional C# 10", Publisher = "Wrox Press" };
            context.Books.Add(book);
            int changed = context.SaveChanges();
        }

        private static void CreateTheDatabase()
        {
            using var context = new BooksContext();
            bool created = context.Database.EnsureCreated();
            Console.WriteLine($"database created: {created}");
        }
    }
}
