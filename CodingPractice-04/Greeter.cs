using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;



public class Greeter
{
    public void SayHello()
    {
        WriteLine("인스턴스 메서드: 안녕하세요!");
    }
}

public static class GreeterExtensions
{
    public static void SayHello(this Greeter greet)
    {
        WriteLine("확장 메서드: 반갑습니다!");
    }
    public static void SayGoodBye(this Greeter greet)
    {
        WriteLine("확장 메서드: 안녕히 가세요!");
    }
}