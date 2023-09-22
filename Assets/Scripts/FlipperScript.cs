using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperScript : MonoBehaviour
{
    [SerializeField] private AnimationCurve animationCurve;
    [SerializeField] private float flipDirection;

    private float timer;
    private Rigidbody flipperRB;
    private Quaternion startRotation;

    private void Awake() {
        startRotation = transform.rotation;
        flipperRB = GetComponent<Rigidbody>();
    }

    private void Update() {
        if  (Input.GetKeyDown(KeyCode.Space)) {
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    private void FixedUpdate() {
        // Rotatsjon logik
        // Instead of rotating object using transform.rotation / transform.localEulerAngles
        // we use rigidbody.MoveRotation. This rotates the object in the physicsstep (Fixed Update) and ensures 
        // other raindrops / pinballs dont clip through and receives velocity!
        
        flipperRB.MoveRotation(startRotation * Quaternion.Euler(animationCurve.Evaluate(timer) * flipDirection, 0, 0));
    }
}