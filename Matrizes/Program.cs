using Matrizes;

namespace evenodd
{
    class Program
    {
        static void Main(string[] args)
        {
            countEvenOdd countEvenOdd = new countEvenOdd();

            int[,] array = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 9 } };

            int result = countEvenOdd.CountEvenOdd(array);

           Console.WriteLine(result);
        }
    }
}
