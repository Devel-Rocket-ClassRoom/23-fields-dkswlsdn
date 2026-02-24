using System;
using System.Collections.Generic;
using System.Text;

public class ScoreTracker
{
    public const int k_MaxScore = 100;
    public const int k_MinScore = 0;

    public readonly string subjectName;
    private int currentScore;
    private int bonusScoreTimes;

    public ScoreTracker(string subjectName)
    {
        this.subjectName = subjectName;
        currentScore = 0;
        bonusScoreTimes = 0;
    }

    public void SetScore(int score)
    {
        if (score < k_MinScore || score > k_MaxScore)
        {
            Console.WriteLine("오류: 범위를 벗어남");
            return;
        }

        currentScore = score;
        Console.WriteLine($"점수를 {score}점으로 설정했습니다.");
    }

    public void AddBonus(int bonus)
    {
        if (currentScore + bonus > k_MaxScore)
        {
            currentScore = k_MaxScore;
        }

        bonusScoreTimes++;
        Console.WriteLine($"{bonus}점 보너스 적용! 현재 점수: {currentScore}점");
    }

    public void ShowScore()
    {
        Console.WriteLine($"=== {subjectName} ===");
        Console.WriteLine($"점수: {currentScore} / {k_MaxScore}");
        Console.WriteLine($"보너스 적용 횟수: {bonusScoreTimes}");
    }
}