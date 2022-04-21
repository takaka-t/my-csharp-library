using System;

namespace Helper
{
    /// <summary>
    /// 計算
    /// </summary>
    public static class Calculate
    {
        /// <summary>
        /// 割合を計算する
        /// </summary>
        /// <param name="value">値</param>
        /// <param name="percent">パーセント(%)</param>
        /// <returns>{value}の{percent}%</returns>
        public static decimal MultiplyePercent(decimal value, decimal percent)
        {
            return value * ( percent / 100 );
        }

        /// <summary>
        /// 指定した桁をFloor関数で切り捨てる
        /// </summary>
        /// <param name="value">値</param>
        /// <param name="digit">指定する桁</param>
        /// <returns></returns>
        public static decimal FloorBySpecifieDigit(decimal value ,sbyte digit)
        {
            //var multiply = Math.Pow(digit, 10);
            decimal multiply = 1;
            for (sbyte i = 0; i < digit - 1; i++) { multiply *= 10;}
            return Math.Floor(value * multiply) / multiply;
        }

        /// <summary>
        /// 指定した桁をTruncate関数で切り捨てる
        /// </summary>
        /// <param name="value">値</param>
        /// <param name="digit">指定する桁</param>
        /// <returns></returns>
        public static decimal TruncateBySpecifieDigit(decimal value, sbyte digit)
        {
            //var multiply = Math.Pow(digit, 10);
            decimal multiply = 1;
            for (sbyte i = 0; i < digit - 1; i++) { multiply *= 10; }
            return Math.Truncate(value * multiply) / multiply;
        }

        /// <summary>
        /// 指定した桁をCeiling関数で切り上げる
        /// </summary>
        /// <param name="value">値</param>
        /// <param name="digit">指定する桁</param>
        /// <returns></returns>
        public static decimal CeilingBySpecifieDigit(decimal value, sbyte digit)
        {
            //var multiply = Math.Pow(digit, 10);
            decimal multiply = 1;
            for (sbyte i = 0; i < digit - 1; i++) { multiply *= 10; }
            return Math.Ceiling(value * multiply) / multiply;
        }

        /// <summary>
        /// 指定した桁をRound関数で四捨五入する
        /// ※mode変更可能
        /// </summary>
        /// <param name="value">値</param>
        /// <param name="digit">指定する桁</param>
        /// <returns></returns>
        public static decimal RoundBySpecifieDigit(decimal value, sbyte digit, MidpointRounding mode = MidpointRounding.AwayFromZero)
        {
            //var multiply = Math.Pow(digit, 10);
            decimal multiply = 1;
            for (sbyte i = 0; i < digit - 1; i++) { multiply *= 10; }
            return Math.Round(value * multiply, mode) / multiply;
        }
    }
}
