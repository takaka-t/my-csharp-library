using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension.BasicDataType
{

    /// <summary>
    /// String型拡張
    /// </summary>
    public static class StringExtension
    {

        /// <summary>
        /// IsNullOrEmpty拡張
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string val)
        {
            return string.IsNullOrEmpty(val);
        }

        /// <summary>
        /// IsNullOrEmpty拡張
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static bool IsNullOrWhiteSpace(this string val)
        {
            return string.IsNullOrWhiteSpace(val);
        }

    }

}
