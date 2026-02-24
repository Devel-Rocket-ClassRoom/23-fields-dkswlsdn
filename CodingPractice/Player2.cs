using System;
using System.Collections.Generic;
using System.Text;

public class Player2
{
    string name = "이름없음";
    int health = 100;
    int level = 1;

    public void ShowStatus()
    {
        Console.WriteLine($"이름: {name}");
        Console.WriteLine($"체력: {health}");
        Console.WriteLine($"레벨: {level}");
    }
}
