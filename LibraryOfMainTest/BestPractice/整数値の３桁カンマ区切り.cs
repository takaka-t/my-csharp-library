using System;
using Xunit;

namespace LibraryOfMainTest.BestPractice
{
    /// <summary>
    /// 参考
    /// ・https://dobon.net/vb/dotnet/string/inttostring.html
    /// </summary>
    public class 数値の３桁カンマ区切り
    {
        /// <summary>
        /// 最適解とする
        /// </summary>
        [Fact]
        public void Best()
        {
            int value = 1234567;
            string result = value.ToString("#,0");

            Assert.Equal("1,234,567", result);
        }

        /// <summary>
        /// 記述量が多いので非推奨
        /// </summary>
        [Fact]
        public void Else1()
        {
            int value = 1234567;
            string result = string.Format("{0:N0}", value);

            Assert.Equal("1,234,567", result); 
        }

    }
}
