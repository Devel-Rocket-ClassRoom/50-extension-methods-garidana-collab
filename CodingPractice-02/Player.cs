using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Security;
using System.Reflection.Emit;
using System.Text;
using System.Xml.Linq;
using static System.Console;



public class Player
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int Exp { get; set; }
    public Player (string name, int lvl, int exp)
    {
        Name = name;
        Level = lvl;
        Exp = exp;
    }
}

public static class PlayerExtensions
{
    public static string GetInfo(this Player player)
    {
        return $"[{player.Name}] 레벨: {player.Level}, 경험치: {player.Exp}";
    }
    public static bool CanLevelUp(this Player player)
    {
        if (player.Exp >= 100)
        {
            return true;
        }
        return false;
    }
    public static void LevelUp (this Player player)
    {
        player.Level++;
        player.Exp -= 100;
    }
}