using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public GameObject scoreText;
    public int score = 0;

    void Start()
    {
        UpdateScore();
    }

    public void UpdateScore()
    {
        scoreText.GetComponent<TMP_Text>().text = "Score: " + score;
    }
}