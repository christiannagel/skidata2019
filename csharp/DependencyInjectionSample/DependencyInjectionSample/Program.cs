using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependencyInjectionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // var controller = new HomeController(new GreetingService());
            var container = RegisterServices();
            var controller = container.GetService<HomeController>();
            string result = controller.Index("Stephanie");
            Console.WriteLine(result);
        }

        public static IServiceProvider RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddScoped<IGreetingService, GreetingService>();
            services.AddTransient<HomeController>();
            return services.BuildServiceProvider();
        }
    }
}
