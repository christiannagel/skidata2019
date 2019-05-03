using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace BlockingCollectionSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var coll = new BlockingCollection<int>();
            Task t1 = WriterAsync(coll);
            await Task.Delay(100);
            Task t2 = ReaderAsync(coll);
            await Task.WhenAll(t1, t2);
        }

        static Task WriterAsync(BlockingCollection<int> coll)
        {
            return Task.Run(async () =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    await Task.Delay(10);
                    coll.Add(i);
                }
                coll.CompleteAdding();
            });
        }

        static Task ReaderAsync(BlockingCollection<int> coll)
        {
            return Task.Run(() =>
            {
                foreach (int item in coll.GetConsumingEnumerable())
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("finished");
            });
        }
    }
}
