using LambdaX.Console;
using Xunit;

namespace LambdaX.tests
{
    public class NumberOfWaysTests
    {
        [Theory]
        [InlineData(4, new int[] {1, 2, 3}, 3, 4)]
        [InlineData(10, new int[] {2, 5, 3, 6}, 4, 5)]
        [InlineData(0, new int[] {2, 5, 3, 6}, 4, 1)]
        [InlineData(-1, new int[] {2, 5, 3, 6}, 4, 0)]
        public void NumberOfWaysShouldReturnCorrectNumber(int amount, int[] denominations,
            int denominationsArrayLength, int expectedResult)
        {
            var sut = new Coin();

            var result = sut.NumberOfWays(denominations, denominationsArrayLength, amount);

            Assert.Equal(expectedResult, result);
        }
    }
}