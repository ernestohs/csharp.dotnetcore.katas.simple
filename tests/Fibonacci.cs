using System;
using Katas.Basic;
using Xunit;

namespace Katas.Basic.Tests
{
    public class FibonacciTests
    {
        [Theory]
        [InlineData(0,0)]
        [InlineData(1,1)]
        [InlineData(2,1)]
        [InlineData(3,2)]
        [InlineData(4,3)]
        [InlineData(5,5)]
        [InlineData(6,8)]
        [InlineData(7,13)]
        [InlineData(8,21)]
        [InlineData(9,34)]
        [InlineData(10,55)]
        [InlineData(11, 89)]
        [InlineData(12, 144)]
        [InlineData(13, 233)]
        [InlineData(14, 377)]
        [InlineData(15, 610)]
        [InlineData(16, 987)]
        [InlineData(17, 1597)]
        [InlineData(18, 2584)]
        [InlineData(19, 4181)]
        public void FibonacciTest(int number, int expected)
        {
            var target = new Fibonacci();
            var actual = target.Get(number);

            Assert.Equal(actual, expected);
        }
    }
}
