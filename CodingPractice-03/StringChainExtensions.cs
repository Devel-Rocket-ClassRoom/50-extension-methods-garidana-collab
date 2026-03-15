using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Console;


static class StringChainExtensions
{
    // 접두사 추가
    public static string AddPrefix(this string text, string prefix)
    {
        return prefix + text;
    }
    // 접미사 추가
    public static string AddSuffix(this string text, string suffix)
    {
        return text + suffix;
    }
    // 처음 N 글자만 반환
    public static string Take (this string text, int count)
    {
        if (string.IsNullOrEmpty(text) || count >= text.Length)
        {
            return text;
        }
        return text.Substring(0, count);
    }
    // 말줄임표 추가
    public static string AddElipsis (this string text)
    {
        return text + "...";
    }
}