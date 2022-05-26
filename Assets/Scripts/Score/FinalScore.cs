using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text scoreText;

    void Start() {
        scoreText.text = ScoreManager.instance.ToString();
    }
}
