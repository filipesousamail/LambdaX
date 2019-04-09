using System.Collections.Generic;

namespace LambdaX.Console
{
    public class Coin
    {
        // inspired from https://www.geeksforgeeks.org/coin-change-dp-7
        public int NumberOfWays(int[] denominations, int arrayLength, int amount)
        {
            if (amount == 0) return 1; 
            
            if (amount < 0) return 0; 
        
            if (arrayLength <= 0 && amount >= 1) return 0;
        
            return NumberOfWays( denominations, arrayLength - 1, amount ) + 
                   NumberOfWays( denominations, arrayLength, amount - denominations[arrayLength - 1] ); 
        }
    }
}