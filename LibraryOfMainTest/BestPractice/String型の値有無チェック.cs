using System;
using Xunit;

namespace LibraryOfMainTest.BestPractice
{
    public class String型の値有無チェック
    {
        /// <summary>
        /// 値有無チェックの最適解
        /// </summary>
        /// <param name="value"></param>
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Best1True(string value)
        {
            bool result = string.IsNullOrEmpty(value);
            Assert.True(result);
        }

        /// <summary>
        /// 値有無チェックの最適解
        /// </summary>
        /// <param name="value"></param>
        [Theory]
        [InlineData("AAA")]
        [InlineData(" ")]
        public void Best1False(string value)
        {
            bool result = string.IsNullOrEmpty(value);
            Assert.False(result);
        }

        /// <summary>
        /// 空白ありの値有無チェックの最適解
        /// </summary>
        /// <param name="value"></param>
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData(" ")]
        public void Best2True(string value)
        {
            bool result = string.IsNullOrWhiteSpace(value);
            Assert.True(result);
        }

        /// <summary>
        /// 空白ありの値有無チェックの最適解
        /// </summary>
        /// <param name="value"></param>
        [Theory]
        [InlineData("AAA")]
        public void Best2False(string value)
        {
            bool result = string.IsNullOrWhiteSpace(value);
            Assert.False(result);
        }

    }
}
