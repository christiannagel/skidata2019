using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientApp.Services
{
    public interface IBooksClientService
    {
        Task<IEnumerable<Book>> GetBooksAsync();
    }
}