using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public static int score = 0;
    public static int highScore = 0;

    public static void AddScore(int amount)
    {
        score += amount;
        if (score > highScore)
        {
            highScore = score;
        }
    }

    public static void ResetScore()
    {
        score = 0;
    }

    public static void ResetHighScore()
    {
        highScore = 0;
    }

    public static int GetScore()
    {
        return score;
    }

    public static int GetHighScore()
    {
        return highScore;
    }

    public static int GetLevel()
    {
        return score / 5 + 1;
    }

    public static void ResetAll()
    {
        ResetScore();
        ResetHighScore();
    }
}
