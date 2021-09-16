using TMPro;
using UnityEngine;
using System.Collections;
using System;

public class Score : MonoBehaviour
{
    private int finalPoints;
    private int bestScorePoints = 0;
    public TMP_Text scoreText;
    public TMP_Text bestScore;
    public void NewScore(int points)
    {
        finalPoints += points;
        scoreText.text = "You Score" + "\n" + finalPoints.ToString();
    }
    public void AddBestScore()
    {
        if(bestScorePoints < finalPoints)
        {
            bestScorePoints = finalPoints;
            bestScore.text = "Best Score: " + bestScorePoints.ToString();
            SaveScore();
        }
    }

    private void SaveScore()
    {
        PlayerPrefs.SetInt("best_score", bestScorePoints);
    }
    public void LoadScore()
    {
        bestScorePoints = PlayerPrefs.GetInt("best_score");
        bestScore.text = "Best Score: " + bestScorePoints.ToString();
    }
}
