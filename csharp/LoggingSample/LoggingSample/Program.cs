using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace LoggingSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = RegisterServices();
            var controller = container.GetService<MyController>();
            controller.Foo();
            controller.Bar();
        }

        public static IServiceProvider RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddLogging(config =>
            {
                config.AddFilter(level => level >= LogLevel.Trace);
                config.AddConsole();
                config.AddDebug();
            });
            services.AddTransient<MyController>();
            return services.BuildServiceProvider();
        }
    }
}
