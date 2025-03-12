using System;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public static ScoreText Instance { get; private set; }

    private int score = 0;
    private int highScore = 0;

    [SerializeField] private Text scoreText;
    [SerializeField] private Text highScoreText;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;    
        }
    }

    private void Start()
    {
        LoadHighScore();
        ResetScore();
    }

    private void LoadHighScore()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    public void ResetScore()
    {
        score = 0;
        UpdateScoreUI();
    }

    public void IncreaseScore()
    {
        score += 1;
        if(score > highScore)
        {
            highScore = score;
            SaveHighScore();
        }
        UpdateScoreUI();
    }

    private void SaveHighScore()
    {
        PlayerPrefs.SetInt("HighScore", highScore);
        PlayerPrefs.Save();
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null) {
            scoreText.text = "Score: " + score;
        }

        if (highScoreText != null) {
            highScoreText.text = "High Score: " + highScore;
        }
    }
}
