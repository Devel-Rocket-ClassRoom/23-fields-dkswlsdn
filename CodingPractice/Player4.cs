using System;
using System.Collections.Generic;
using System.Text;

public class Player4
{
    private string name;
    private int level;

    public void SetInfo(string name, int level)
    {
        this.name = name;
        this.level = level;

        Console.WriteLine($"이름: {this.name}");
        Console.WriteLine($"레벨: {this.level}");
    }
}
