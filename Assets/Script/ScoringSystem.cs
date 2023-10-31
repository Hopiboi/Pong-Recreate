using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoringSystem : MonoBehaviour
{
    public UnityEvent scoreTrigger;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        BallMovement ball = collision.gameObject.GetComponent<BallMovement>();

        if (ball != null)
        {
            scoreTrigger.Invoke();
        }
    }
}
