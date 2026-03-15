using System;
using System.Linq;
using static System.Console;

// 1 
WriteLine($"단어 개수: {StringHelper.CountWords("안녕하세요 반갑습니다")}");

WriteLine();

// 2
WriteLine($"단어 개수: {StringExtensions.CountWords("안녕하세요 반갑습니두")}");

WriteLine();

// 3
int num1 = 10;
int num2 = 7;

WriteLine($"{num1}은(는) 짝수인가? {num1.IsEven()}");
WriteLine($"{num2}은(는) 홀수인가? {num2.IsOdd()}");
// 확장 메서드에서 this 매개변수는 앞에 배치하는 구조임.
// 만들땐 확장메서드이름(this 매개변수, 매개변수)
// 호출 할땐 this에매개변수.메서드이름(매개변수)
WriteLine($"3을 5번 반복: {3.Repeat(5)}");

WriteLine();

