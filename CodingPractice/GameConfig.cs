using System;
using System.Collections.Generic;
using System.Text;

public class GameConfig
{
    public readonly string version = "1.0.0";
    public readonly int maxPlayer;

    public GameConfig()
    {
        maxPlayer = 4;
    }

    public void ShowConfig()
    {
        Console.WriteLine($"버전: {version}");
        Console.WriteLine($"최대 플레이어: {maxPlayer}");
    }
}