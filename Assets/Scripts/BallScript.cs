using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private Rigidbody ballRB;

    private void Awake() {
        ballRB = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other) {
        if  (other.gameObject.CompareTag("Obstacle")) 
        {
            UIScript.Instance.score += 1;
            ballRB.AddForce(other.GetContact(0).normal * 20.0f, ForceMode.Impulse);
        }
        else if  (other.gameObject.CompareTag("BottomWallTag")) 
        {
            UIScript.Instance.bGameIsRunning = false;
        }
    }
}
