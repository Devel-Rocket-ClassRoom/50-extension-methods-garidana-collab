using System;
using System.Collections.Generic;
using System.Text;

static class StringHelper
{
    // 스태틱 클래스에선 액세스 한정자를 정해주지않으면 private이 디폴트로 지정됨
    public static int CountWords(string text)
    {
        int count = 0;
        string[] input = text.Split(' ');
        count = input.Length;
        return count;
    }
}