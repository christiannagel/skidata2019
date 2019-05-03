using System;
using System.Threading;
using System.Threading.Tasks;

namespace AwaitSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //ShowThreadInfo("main");
            //string s1 = await GreetingAsync("Stephanie", 3000);

            //ShowThreadInfo("after first GreetingAsync");
            //string s2= await GreetingAsync("Matthias", 2000);
            //Console.WriteLine("started GreetingAsync");



            Runner();
            Console.WriteLine("completed");
            Console.ReadLine();
        }

        public static async void Runner()
        {
            Task outerTask;
            try
            {
                Task t1 =  ThrowAfterAsync("one", 3000);
                Task t2 =  ThrowAfterAsync("two", 1000);
                outerTask = Task.WhenAll(t2, t1);
                await outerTask;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("runner completed");
        }

        public static void ShowThreadInfo(string title)
        {
            Console.WriteLine($"{title}, current thread: {Thread.CurrentThread.ManagedThreadId}, " +
                $"task: {Task.CurrentId}");
        }

        public static Task<string> GreetingAsync(string name, int ms)
        {
            return Task<string>.Run<string>(() =>
            {
                ShowThreadInfo("in task");
                return Greeting(name, ms);
            });
        }

        public static string Greeting(string name, int ms)
        {
            Thread.Sleep(ms);
            return $"Hello, {name}";
        }

        public static Task ThrowAfterAsync(string title, int ms)
        {
            return Task.Run(() =>
            {
                ThrowAfter(title, ms);
            });
        }

        public static void ThrowAfter(string title, int ms)
        {
            Thread.Sleep(ms);
            throw new Exception($"{title}: bad bad bad");
        }
    }
}
