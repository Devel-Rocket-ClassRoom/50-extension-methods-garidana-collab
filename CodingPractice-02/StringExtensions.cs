using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static System.Console;


static class StringExtensions
{
    public static string First (this string text, int count)
    {
        // 빈 문자열이면 그대로 반환
        if (string.IsNullOrEmpty(text))
        {
            return text;
        }
        if (count >= text.Length)
        {
            return text;
        }
        return text.Substring(0, count);

    }
}