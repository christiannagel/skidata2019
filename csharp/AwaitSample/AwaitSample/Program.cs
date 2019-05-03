using System;
using System.Threading;
using System.Threading.Tasks;

namespace AwaitSample
{
    class Program
    {
        static void Main(string[] args)
        {
        //    ShowThreadInfo("main");
        //    Task<string> t1 = GreetingAsync("Stephanie", 3000);

        //    ShowThreadInfo("after first GreetingAsync");
        //    Task<string> t2 = GreetingAsync("Matthias", 2000);
        //    Console.WriteLine("started GreetingAsync");

        //    await Task.WhenAll(t1, t2);
        //    Console.WriteLine(t1.Result);

            Runner();
            Console.WriteLine("completed");
            Console.ReadLine();
        }

        public static async void Runner()
        {
            try
            {
                await ThrowAfterAsync(1000);
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

        public static Task ThrowAfterAsync(int ms)
        {
            return Task.Run(() =>
            {
                ThrowAfter(ms);
            });
        }

        public static void ThrowAfter(int ms)
        {
            Thread.Sleep(ms);
            throw new Exception("bad bad bad");
        }
    }
}
