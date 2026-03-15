using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Linq;
using static System.Console;

// 정적클래스와 정적메서드로만 메서드 확장 가능
static class InTextensions
{
    public static bool IsEven(this int number)
    {
        if (number % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

    public static bool IsOdd (this int number)
    {
        if (number % 2 == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static string Repeat (this int number, int times)
    {
        // Enumerable 은 Linq의 일부이므로 상단에 using Linq넣어주기
        // 매개변수의 times를만큼 첫번째 인자를 반복하는 IEnumerable시퀀스를 생성
        // Concat = 생성된 문자열 시퀀스의 모든 요소를 순서대로 이어붙여 하나의 문자열로 반환해줌
        return string.Concat(Enumerable.Repeat(number.ToString(), times));
    }
}
