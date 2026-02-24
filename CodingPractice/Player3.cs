using System;
using System.Collections.Generic;
using System.Text;

public class Player3
{
    public string name;
    static public int totalCount;

    public Player3(string name)
    {
        this.name = name;
        totalCount++;
    }
}