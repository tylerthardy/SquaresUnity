using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{

    public Text scoreText;

    public void UpdateScore()
    {
        scoreText.text = GameMaster.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScore();
    }
}