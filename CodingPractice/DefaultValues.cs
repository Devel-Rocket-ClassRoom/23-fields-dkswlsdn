using System;
using System.Collections.Generic;
using System.Text;

public class DefaultValues
{
    int number;
    bool flag;
    string text;

    public void ShowDefaultValues()
    {
        Console.WriteLine($"number: {number}");
        Console.WriteLine($"flag: {flag}");
        if (text == null)
        {
            Console.WriteLine("text: null");
        }
        else
        {
            Console.WriteLine($"text: {text}");
        }
    }
}