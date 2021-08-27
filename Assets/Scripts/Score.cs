using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int finalPoints;
    public Text scoreText;
    public void NewScore(int points)
    {
        finalPoints += points;
        scoreText.text = "You Score" + "\n" + finalPoints.ToString();
    }
}
