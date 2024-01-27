using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public static int score = 0;
    public static int highScore = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI levelText;

    void Start()
    {
        Debug.Log("Scoring.Start");
        scoreText.text = "SCORE: " + GetScore().ToString();
        levelText.text = "LEVEL: " + GetLevel().ToString();
    }

    void Update()
    {
        scoreText.text = "SCORE: " + GetScore().ToString();
        levelText.text = "LEVEL: " + GetLevel().ToString();
    }

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
        return score / 10 + 1;
    }

}
