using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    [Obsolete("むしろない方が書き方統一できそう",false)]
    public static bool IsNullOrEmpty(this string val)
    {
        return string.IsNullOrEmpty(val);
    }

    /// <summary>
    /// IsNullOrEmpty拡張
    /// </summary>
    /// <param name="val"></param>
    /// <returns></returns>
    [Obsolete("むしろない方が書き方統一できそう",false)]
    public static bool IsNullOrWhiteSpace(this string val)
    {
        return string.IsNullOrWhiteSpace(val);
    }

}