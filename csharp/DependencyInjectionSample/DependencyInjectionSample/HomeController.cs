using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionSample
{
    public class HomeController
    {
        private readonly IGreetingService _service;
        public HomeController(IGreetingService service)
        {
            _service = service;
        }
        public string Index(string name)
        {
            //var service = new GreetingService();
            //string result = service.Greet(name);
            //return result.ToLower();

            return _service.Greet(name).ToLower();
        }
    }
}
