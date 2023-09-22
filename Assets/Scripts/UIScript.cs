using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditorInternal;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI TimeText;

    public static UIScript Instance; 
    public int score = 0;
    public float timer;
    public bool bGameOver = false;

    private void Start() 
    {
        Instance = this;
        //ScoreText = GetComponentInChildren<TextMeshProUGUI>();
        ScoreText.text = "Score: " + score.ToString() + " Points";
        //TimeText = GetComponentInChildren<TextMeshProUGUI>();
    }
    
    private void Update() 
    {
        if (!bGameOver) {
            timer += Time.deltaTime;
            ScoreText.text = "Score: " + score.ToString() + " Points";
            TimeSpan ts = TimeSpan.FromSeconds(timer);
            TimeText.text = "Time: " + ts.ToString("hh\\:mm\\:ss");
        }
    }
}
