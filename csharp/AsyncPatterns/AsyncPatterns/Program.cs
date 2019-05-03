using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // AsyncPattern();
            // AsyncEventPattern();
            TaskBasedAsyncPattern();
            Console.ReadLine();
        }

        private static async void TaskBasedAsyncPattern()
        {
            var client = new HttpClient();
            await client.GetAsync("https://csharp.christiannagel.com");
        }

        private static void AsyncEventPattern()
        {
            WebClient client = new WebClient();
            
            client.DownloadFileCompleted += (sender, e) =>
            {
                Console.WriteLine("local file created");
            };
            client.DownloadFileAsync(new Uri("http://csharp.christiannagel.com"), "localfile.txt");
            
        }

        private static void AsyncPattern()
        {

            var req = HttpWebRequest.Create("https://csharp.christiannagel.com");
            
            IAsyncResult ar = req.BeginGetResponse(MyCallback, req);

            var ar1 = req.BeginGetResponse(ar2 =>
            {
                // req. // closure
            }, null);

            Console.WriteLine("do something else");

        }

        private static void MyCallback(IAsyncResult ar)
        {
            var req = ar.AsyncState as WebRequest;
          
        }
    }
}
