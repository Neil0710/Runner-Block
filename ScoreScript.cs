using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    public Text finalScoreText;
    int myScore = 0;
  
    void Update()
    {
        scoreText.text = myScore.ToString();
        finalScoreText.text = "Score:"+ myScore.ToString();
    }
    public void AddScore(int score)
    {
        myScore = myScore + score;
    }
}
