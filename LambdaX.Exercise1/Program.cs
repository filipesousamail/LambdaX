using System;
using System.Collections.Generic;

namespace LambdaX.Console
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var coin = new Coin();
            var denominations = new int[] { 1, 2, 3 };
            var amount = 4;
            var arrayLength = denominations.Length;
            
            var res = coin.NumberOfWays(denominations, arrayLength, amount);

            System.Console.WriteLine(res.ToString());
        }
    }
}
