using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

public static class Palindrom
{
    public static bool IsPalindrome(this string str)
    {
        string letterOrNum = "";
        if (str == null || str == string.Empty)
        {
            return false;
            
        }
        else
        {
            foreach (var c in str)
            {
                if (char.IsLetterOrDigit(c))
                {
                    letterOrNum += c;
                    
                }
            }
            letterOrNum = letterOrNum.ToLower();

            for (int i = 0, j = letterOrNum.Length - 1; i < j; i++, j--)
            {
                if (!(letterOrNum[i] == letterOrNum[j]))
                {
                    return false;
                }
            }
            return true;
        }
        
    }
}