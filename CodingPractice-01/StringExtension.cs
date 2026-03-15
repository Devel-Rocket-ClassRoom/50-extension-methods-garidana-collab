using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

public static class StringExtensions
{
    // 정적 메서드의 매개변수앞에 this를 붙이면 지금의 경우 string에 종속되는
    // 메서드로 만들어서 사용하겠다는 의미임.
    public static int CountWords(this string text)
    {
        // 매개변수로 받은 text가 비어있는 string인지 확인
        if (string.IsNullOrEmpty(text))
        {
            // 비어있을 시 0 반환
            return 0;
        }
        // 공백문자' '로 string을 분할하고 Length 반환
        return text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    }
}

