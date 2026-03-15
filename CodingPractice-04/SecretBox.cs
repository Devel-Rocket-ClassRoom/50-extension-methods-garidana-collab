using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Console;


// 확장 메서드의 경우 대상 타입의 private이나 protected 보안 수준의 멤버에는 접근 불가능
public class SecretBox
{
    private string _secret = "secert";
    public string PublicData = "public";
    
    
}

public static class SecreBoxExtensions
{
    public static void ShowData(this SecretBox box)
    {
        WriteLine($"공개 데이터: {box.PublicData}");
    }
}
