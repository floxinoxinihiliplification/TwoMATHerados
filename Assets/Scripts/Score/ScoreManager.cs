using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;

    int score = 0;

    private void Awake() {
        instance = this;
    }

    void Start() {
        scoreText.text = score.ToString();
    }

    public void AddPoints(int points) {
        score += points;
        scoreText.text = score.ToString();
    }
}