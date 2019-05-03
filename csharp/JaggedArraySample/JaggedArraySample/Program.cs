using System;

namespace JaggedArraySample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 3 };
            int[,] twodim = new int[3, 4];
  

            int[][] jagged = new int[5][];
            jagged[0] = new int[4];
            jagged[1] = new int[8];
            jagged[2] = new int[40];
            jagged[3] = new int[4];
        }
    }
}
