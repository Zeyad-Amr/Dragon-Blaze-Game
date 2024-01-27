using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameOverScreen : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public GameObject enemyPrefab;

    void Start()
    {
        Debug.Log("GameOverScreen.Start");
        highScoreText.text = "HIGH SCORE: " + Scoring.GetHighScore().ToString();
        scoreText.text = Scoring.GetScore().ToString() + " POINTS";
    }

    public void RestartGame()
    {
        Debug.Log("GameOverScreen.RestartGame");
        Scoring.ResetScore();
        SceneManager.LoadScene("GameScene");
    }

}
