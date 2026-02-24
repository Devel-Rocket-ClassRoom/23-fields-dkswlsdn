using System;
using System.Collections.Generic;
using System.Text;

public class Player
{
    string name;
    int health;

    public void ShowStatus()
    {
        Console.WriteLine($"이름: {name}");
        Console.WriteLine($"체력: {health}");
    }
}
