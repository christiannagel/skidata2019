using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.Services
{
    public class BooksClientService : IBooksClientService
    {
        private HttpClient _client;
        public BooksClientService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            try
            {
                HttpResponseMessage resp = await _client.GetAsync("/api/Books");
                resp.EnsureSuccessStatusCode();
                string json = await resp.Content.ReadAsStringAsync();
                var books = JsonConvert.DeserializeObject<IEnumerable<Book>>(json);
                return books;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
