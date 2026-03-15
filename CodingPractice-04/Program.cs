using System;
using static System.Console;


// 1
string str = "    hello World    ";
// 중첩 호출 방식
// str Trim - Upper - Replace 공백 with  _
string layer = StringExtensions.Replace(StringExtensions.Upper(StringExtensions.Trim(str)), ' ', '_');
string chain = str.Trim().Upper().Replace(' ', '_');

WriteLine($"결과1: {layer}");
WriteLine($"결과2: {chain}");

WriteLine();

// 2
SecretBox box = new SecretBox();
box.ShowData();

WriteLine();

// 3

Greeter greet = new();
greet.SayHello();
// 확장 메서드 호출 (인스턴스에는 이게 없기 때문) 
greet.SayGoodBye();
GreeterExtensions.SayHello(greet);
// 동일 시그니처의 인스턴스 메서드가 존재시 확장메서드보다 인스턴스 메서드가 우선적으로 호출됨.
