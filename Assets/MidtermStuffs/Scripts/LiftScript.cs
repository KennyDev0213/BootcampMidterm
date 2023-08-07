using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftScript : MonoBehaviour
{
    Vector3 startPosition, endPosition, targetPosition;

    float activatedTime = 0;
    public float activationTime = 5f, liftSpeed = 2f, VectorAccuracy = 0.1f;
    public Transform endPoint;

    private void Start() {
        startPosition = transform.position;
        endPosition = endPoint.position;
        targetPosition = startPosition;
    }

    public void ActivateLift()
    {
        targetPosition = endPosition;
        activatedTime = activationTime;
    }

    private void FixedUpdate() {
        if (Vector3.Distance(transform.position, targetPosition) >= VectorAccuracy) 
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, liftSpeed * Time.deltaTime);
        }

        activatedTime -= Time.deltaTime;
        if (activatedTime <= 0)
        {
            targetPosition = startPosition;
        }
    }
}
