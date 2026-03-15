using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


public static class StringExtensions
{
    public static bool IsCapitalized (this string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return false;
        }
        // IsUpper는 'char' 데이터 형에만 해당 (string의 [i]번째 배열이 대문자인지 
        return char.IsUpper(text[0]);
    }
    public static string Capitalize (this string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return text;
        }
        // 첫 글자를 대문자로 바꾸고, 나머지 글자들은 소문자로 처리해서 반환
        // SubString(1)은 string의 인덱스1부터 끝까지를 의미함
        return char.ToUpper(text[0]) + text.Substring(1).ToLower();
    }
    public static string Reverse (this string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return text;
        }
        char[] charArrays = text.ToCharArray();
        Array.Reverse(charArrays);
        return new string(charArrays);
    }
}