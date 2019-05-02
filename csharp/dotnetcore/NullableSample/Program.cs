using System;

namespace NullableSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string? s = null;

            Console.WriteLine(s);

            if (s != null)
            {
                string s1 = s.ToUpper();
            }

            string s2 = s?.ToUpper() ?? string.Empty;
        }
    }
}
