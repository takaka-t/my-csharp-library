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
        /// <param name="target"></param>
        /// <param name="percent"></param>
        /// <returns>{target}の{percent}%</returns>
        public static decimal MultiplyePercent(decimal target, decimal percent)
        {
            return target * ( percent / 100 );
        } 

        /// <summary>
        /// 指定した桁をFloor関数で切り捨てる
        /// </summary>
        /// <param name="target"></param>
        /// <param name="Digit"></param>
        /// <returns></returns>
        public static decimal FloorBySpecifieDigit(decimal target ,byte Digit)
        {
            throw new NotImplementedException();
        }

    }
}
