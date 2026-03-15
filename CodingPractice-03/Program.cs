using System;
using System.Collections.Generic;
using static System.Console;


// 1
string hello = "hello";
WriteLine($"'{hello}' 대문자로 시작?: {StringExtensions.IsCapitalized("hello")}");
WriteLine($"첫 글자 대문자: {StringExtensions.Capitalize(hello)}");
WriteLine($"뒤집기: {StringExtensions.Reverse(hello)}");

WriteLine();

// 2
string greet = "안녕하세요 반갑습니다 좋은 하루 되세요";
WriteLine(greet.Take(10).AddElipsis().AddPrefix("[메시지]").AddSuffix("(더보기)"));

WriteLine();

// 3
string[] names = { "철수", "영희", "민수" };
List<int> numList = new List<int>();
WriteLine($"names 비어있음? {names.IsEmpty()}");
WriteLine($"emptyList 비어있음? {numList.IsEmpty()}");
WriteLine($"names에 요소 있음? {names.HasItems()}");
WriteLine();
WriteLine($"이름 목록:\n\t- {names[0]}\n\t- {names[1]}\n\t- {names[2]}");