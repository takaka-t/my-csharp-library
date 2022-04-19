using System;
using Xunit;

namespace LibraryOfMainTest.Extention
{

    /// <summary>
    /// String拡張テスト
    /// </summary>
    public class StringExtensionTest
    {

        /// <summary>
        /// IsNullOrEmpty拡張テスト
        /// ※ひとつの関数の結果を複数条件でテストする場合はTheory使うべきっぽい
        /// </summary>
        [Fact]
        public void IsNullOrEmpty()
        {
            const string emptyValue = "";
            Assert.True(emptyValue.IsNullOrEmpty(), "空文字テスト失敗");

            const string nullValue = null;
            Assert.True(nullValue.IsNullOrEmpty(), "nullテスト失敗");

            const string strValue = "あああ";
            Assert.False(strValue.IsNullOrEmpty(), "文字ありテスト失敗");

            const string strValueWithWhiteSpace = "あああ   ";
            Assert.False(strValueWithWhiteSpace.IsNullOrEmpty(), "空白付き文字ありテスト失敗");

            const string whiteSpaceValue = "   ";
            Assert.False(whiteSpaceValue.IsNullOrEmpty(), "空白付き文字ありテスト失敗");
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("　　　")] // 全角
        [InlineData(null)]
        public void IsNullOrWhiteSpaceTestAssertTrue(string value)
        {
            Assert.True(value.IsNullOrWhiteSpace());
        }

        [Theory]
        [InlineData("ああ")]
        [InlineData("いい　　")]
        [InlineData("　　いい　　")]
        [InlineData("　　いい")]
        public void IsNullOrWhiteSpaceTestAssertFalse(string value)
        {
            Assert.False(value.IsNullOrWhiteSpace());
        }
    }
}

