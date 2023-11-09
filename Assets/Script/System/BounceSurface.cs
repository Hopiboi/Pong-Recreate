using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceSurface : MonoBehaviour
{
    [SerializeField] private float bouncinessStregth;

    //increasing the speed
    private void OnCollisionEnter2D(Collision2D collision)
    {
        BallMovement ball = collision.gameObject.GetComponent<BallMovement>();

        if (ball != null)
        {
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddingForce(-normal * this.bouncinessStregth);
        }

    }
}
