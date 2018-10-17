using System;

namespace _01SumOfBiggestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //convert string array to int array
            var input = Array.ConvertAll(args, Int32.Parse);

            SumFider sumFider = new SumFider();
            Console.WriteLine(sumFider.Challenge(input));
        }
    }
}
