using Microsoft.EntityFrameworkCore;
using SimpleEFCoreSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppWithEFCore.Services
{
    public class BooksService : IBooksService
    {
        private BooksContext _context;
        public BooksService(BooksContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            var books = await _context.Books.ToListAsync();
            return books;
        }
    }
}
