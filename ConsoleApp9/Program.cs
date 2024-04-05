using System;
namespace ConsoleApp9;


public class Program
{
    public static int Main()
    {
        int totalScore = 0;
        totalScore += ReadAndCalculateScore(1, 10);
        totalScore += ReadAndCalculateScore(2, 50);
        totalScore += ReadAndCalculateScore(3, 30);
        totalScore += ReadAndCalculateScore(4, 10);

        Console.WriteLine($"Общая сумма баллов: {totalScore}");
        int grade = CalculateGrade(totalScore);
        Console.WriteLine($"Оценка: {grade}");
        return grade;
    }

    static int ReadAndCalculateScore(int taskNumber, int maxScore)
    {
        Console.WriteLine($"Введите баллы за задание №{taskNumber} (макс. {maxScore} баллов):");
        return ReadValidScore(maxScore);
    }

    public static int CalculateGrade(int totalScore)
    {
        if (totalScore >= 70)
            return 5; 
        else if (totalScore >= 40)
            return 4; 
        else if (totalScore >= 20)
            return 3; 
        else
            return 2; 
    }

    public static int ReadValidScore(int maxScore)
    {
        int score;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out score) && score >= 0 && score <= maxScore)
            {
                return score;
            }
            else
            {
                Console.WriteLine($"Неверное значение. Введите целое число от 0 до {maxScore}:");
            }
        }
    }
}
