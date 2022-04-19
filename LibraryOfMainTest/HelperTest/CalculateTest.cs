using System;
using Xunit;

namespace LibraryOfMainTest.HelperTest
{
    public class CalculateTest
    {

        [Fact]
        public void MultiplyePercentTest()
        {
            decimal result = Helper.Calculate.MultiplyePercent(200, 20);
            Assert.Equal(40, result);
        }

        [Fact]
        public void FloorBySpecifieDigitTest()
        {
            decimal result = Helper.Calculate.FloorBySpecifieDigit((decimal)123.456, 2);
            Assert.Equal((decimal)123.4, result);
        }

    }
}
