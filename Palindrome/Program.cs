using System;
using System.Runtime.CompilerServices;
using static System.Console;


string tmt = "토마토";
string grg = "기러기";
string lvl = "level";
string Lvl = "Level";
string panama = "A man, a plan, a canal : Panama";
string rcr = "race a car";
string hello = "hello";
string gnd = "가나다";
string empty = "";

WriteLine("=== 회문 판별 테스트 ===");
WriteLine($"\"{tmt}\" -> {tmt.IsPalindrome()}");
WriteLine($"\"{grg}\" -> {grg.IsPalindrome()}");
WriteLine($"\"{lvl}\" -> {lvl.IsPalindrome()}");
WriteLine($"\"{Lvl}\" -> {Lvl.IsPalindrome()}");
WriteLine($"\"{panama}\" -> {panama.IsPalindrome()}");
WriteLine($"\"{rcr}\" -> {rcr.IsPalindrome()}");
WriteLine($"\"{hello}\" -> {hello.IsPalindrome()}");
WriteLine($"\"{gnd}\" -> {gnd.IsPalindrome()}");
WriteLine($"\"{empty}\" -> {empty.IsPalindrome()}");

