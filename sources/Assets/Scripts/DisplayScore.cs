using UnityEngine;
using TMPro;

public class DisplayScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private static int score;

    public void Start()
    {
        score = 0;
    }

    public static void incrementScore(int points)
    {
        score += points;
    }

    public static int getScore()
    {
        return score;
    }

    public void Update()
    {
        scoreText.SetText("Score: " + score);
    }


}