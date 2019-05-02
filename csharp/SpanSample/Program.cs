using System;

namespace SpanSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 3, 4, 5 };
            var span1 = data.AsSpan();
            var span2 = span1.Slice(2, 2);
            span2[1] = 42;
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
