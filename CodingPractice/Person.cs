using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    readonly string name;
    readonly int age;
    readonly string nickName;
    readonly string[] site;

    public Person(string name, int age, string nickName, string[] site)
    {
        this.name = name;
        this.age = age;
        this.nickName = nickName;
        this.site = site;
    }

    public void ShowProfile()
    {
        Console.WriteLine($"이름: {name}");
        Console.WriteLine($"나이: {age}");
        Console.WriteLine($"닉네임: {nickName}");
        Console.Write($"사이트: ");

        for (int i = 0; i < site.Length; i++)
        {
            if (i != 0)
            {
                Console.Write(", ");
            }

            Console.Write(site[i]);
        }
    }
}