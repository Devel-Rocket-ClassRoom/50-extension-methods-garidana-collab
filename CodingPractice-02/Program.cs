using System;
using static System.Console;


// 1
string hello = "안녕하세요";
WriteLine(hello.First(3));

// 2
Player p = new Player("용사", 5, 150);
WriteLine(PlayerExtensions.GetInfo(p));
WriteLine($"레벨업 가능? {PlayerExtensions.CanLevelUp(p)}");
PlayerExtensions.LevelUp(p);
WriteLine($"용사이(가) 레벨업! 현재 레벨: {p.Level}");
WriteLine(PlayerExtensions.GetInfo(p));



