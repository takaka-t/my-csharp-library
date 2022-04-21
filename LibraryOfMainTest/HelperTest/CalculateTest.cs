using System;
using Xunit;
using Helper;

namespace LibraryOfMainTest.HelperTest
{
    public class CalculateTest
    {

        public class MultiplyePercentTest
        {
            [Fact]
            public void Test1()
            {
                decimal result = Calculate.MultiplyePercent(200, 20);
                Assert.Equal(40, result);
            }
            [Fact]
            public void Test2()
            {
                decimal result = Calculate.MultiplyePercent(200, 120);
                Assert.Equal(240, result);
            }
            [Fact]
            public void Test3()
            {
                decimal result = Calculate.MultiplyePercent(200, (decimal)1.5);
                Assert.Equal(3, result);
            }
            [Fact]
            public void Test4()
            {
                decimal result = Calculate.MultiplyePercent(200, (decimal)1.1);
                Assert.Equal((decimal)2.2, result);
            }
            [Fact]
            public void Test5()
            {
                decimal result = Calculate.MultiplyePercent(200, -20);
                Assert.Equal(-40, result);
            }
        }

        public class FloorBySpecifieDigitTest
        {
            [Fact]
            public void Test1()
            {
                decimal result = Calculate.FloorBySpecifieDigit((decimal)123.456, 2);
                Assert.Equal((decimal)123.4, result);
            }
            [Fact]
            public void Test2()
            {
                decimal result = Calculate.FloorBySpecifieDigit((decimal)123.456, 0);
                Assert.Equal((decimal)123, result);
            }
            [Fact]
            public void Test3()
            {
                decimal result = Calculate.FloorBySpecifieDigit((decimal)123.456, 4);
                Assert.Equal((decimal)123.456, result);
            }
            [Fact]
            public void Test4()
            {
                decimal result = Calculate.FloorBySpecifieDigit((decimal)-1.5, 1);
                Assert.Equal((decimal)-2, result);  // Truncateとのマイナス値の丸め方の違い
            }
        }

        public class TruncateBySpecifieDigitTest
        {
            [Fact]
            public void Test1()
            {
                decimal result = Calculate.TruncateBySpecifieDigit((decimal)123.456, 2);
                Assert.Equal((decimal)123.4, result);
            }
            [Fact]
            public void Test2()
            {
                decimal result = Calculate.TruncateBySpecifieDigit((decimal)123.456, 0);
                Assert.Equal((decimal)123, result);
            }
            [Fact]
            public void Test3()
            {
                decimal result = Calculate.TruncateBySpecifieDigit((decimal)123.456, 4);
                Assert.Equal((decimal)123.456, result);
            }
            [Fact]
            public void Test4()
            {
                decimal result = Calculate.TruncateBySpecifieDigit((decimal)-1.5, 1);
                Assert.Equal((decimal)-1, result); // Floorとのマイナス値の丸め方の違い
            }
        }

        public class CeilingBySpecifieDigitTest
        {
            [Fact]
            public void Test1()
            {
                decimal result = Calculate.CeilingBySpecifieDigit((decimal)123.456, 2);
                Assert.Equal((decimal)123.5, result);
            }
            [Fact]
            public void Test2()
            {
                decimal result = Calculate.CeilingBySpecifieDigit((decimal)123.456, 0);
                Assert.Equal((decimal)124, result);
            }
            [Fact]
            public void Test3()
            {
                decimal result = Calculate.CeilingBySpecifieDigit((decimal)123.456, 4);
                Assert.Equal((decimal)123.456, result);
            }
            [Fact]
            public void Test4()
            {
                decimal result = Calculate.CeilingBySpecifieDigit((decimal)-1.5, 1);
                Assert.Equal((decimal)-1, result);
            }
        }

        public class RoundBySpecifieDigitTest
        {
            [Fact]
            public void Test1()
            {
                decimal result = Calculate.RoundBySpecifieDigit((decimal)123.456, 2);
                Assert.Equal((decimal)123.5, result);
            }
            [Fact]
            public void Test2()
            {
                decimal result = Calculate.RoundBySpecifieDigit((decimal)123.456, 0);
                Assert.Equal((decimal)123, result);
            }
            [Fact]
            public void Test3()
            {
                decimal result = Calculate.RoundBySpecifieDigit((decimal)123.456, 4);
                Assert.Equal((decimal)123.456, result);
            }
            [Fact]
            public void Test4()
            {
                decimal result = Calculate.RoundBySpecifieDigit((decimal)-1.4, 1);
                Assert.Equal((decimal)-1, result); 
            }
            [Fact]
            public void Test5()
            {
                decimal result = Calculate.RoundBySpecifieDigit((decimal)-1.5, 1);
                Assert.Equal((decimal)-2, result);
            }
        }

    }
}
