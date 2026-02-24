using System;
using System.Collections.Generic;
using System.Text;

public class GameCharacter
{
    public static int totalCharacterNumber;

    public const int k_MaxHealth = 100;
    public const int k_MinHealth = 0;

    public readonly string name;
    public int health;
    public int attack;


    public GameCharacter(string name, int attack)
    {
        this.name = name;
        this.attack = attack;

        health = k_MaxHealth;
    }



    public void ShowStatus()
    {
        Console.WriteLine($"=== {name} ===");
        Console.WriteLine($"체력: {health}/{k_MaxHealth}");
        Console.WriteLine($"공격력: {attack}");

        totalCharacterNumber++;
    }

    public void TakeDamage(int takenDamage)
    {
        if (health - takenDamage < k_MinHealth)
        {
            health = 0;
        }
        else
        {
            health -= takenDamage;
        }

        Console.WriteLine($"{name}이(가) {takenDamage}데미지를 받음! 남은 체력: {health}");
    }

    public static void PrintTotalCharacterNumber()
    {
        Console.WriteLine($"총 캐릭터 수: {totalCharacterNumber}");
    }
}