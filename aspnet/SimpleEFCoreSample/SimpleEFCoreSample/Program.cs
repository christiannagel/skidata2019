using System;

namespace SimpleEFCoreSample
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateTheDatabase();
            AddRecords();
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
