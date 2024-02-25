using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score;

    private void Update()
    {
        score = PlayerPrefs.GetInt("TotalScore", 0);
        scoreText.text =  score.ToString();
    }
}

