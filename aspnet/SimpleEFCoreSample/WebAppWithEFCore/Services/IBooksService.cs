using System.Collections.Generic;
using System.Threading.Tasks;
using SimpleEFCoreSample;

namespace WebAppWithEFCore.Services
{
    public interface IBooksService
    {
        Task<IEnumerable<Book>> GetBooksAsync();
    }
}