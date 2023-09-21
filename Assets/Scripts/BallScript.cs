using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    int score = 0;

    TextMeshProUGUI ScoreText;
    TextMeshPro TimeText;

    [SerializeField] Canvas ScoreAndTimerUICanvas;

    private void Start() 
    {
        ScoreText = ScoreAndTimerUICanvas.GetComponentInChildren<TextMeshProUGUI>();
        ScoreText.text = "Score: " + score + " Points";
    }
    
    private void Update() 
    {
        ScoreText.text = "Score: " + score + " Points";
    }

    private void OnCollisionEnter(Collision other) {
        if  (other.gameObject.CompareTag("Obstacle")) 
        {
            score++;
        }
    }
}
