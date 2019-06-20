using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClientApp.Services
{
    public class TheRunner : BackgroundService
    {
        private readonly IBooksClientService _clientService;
        public TheRunner(IBooksClientService clientService)
        {
            _clientService = clientService;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var books = await _clientService.GetBooksAsync();
        }
    }
}
