using System;
using System.Collections.Generic;
using System.Text;

public class Example
{
    const double Pi = 3.14159;
    readonly DateTime createdAt;

    public void ShowValues()
    {
        Console.WriteLine($"원주율: {Pi}");
        Console.WriteLine($"생성 시간: {createdAt}");
    }
}