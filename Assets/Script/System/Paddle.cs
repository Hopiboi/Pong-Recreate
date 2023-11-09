using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    //Holder
    protected Rigidbody2D rg2D;

    public float paddleSpeed = 10f;

    private void Awake()
    {
        rg2D = GetComponent<Rigidbody2D>();
    }
    
    //Resetting Position
    public void ResetPositionPaddle()
    {
        rg2D.position = new Vector2(rg2D.position.x, 0f);
        rg2D.velocity = Vector2.zero;
    }

    public void ResetPositionPaddleHorizontal()
    {
        rg2D.position = new Vector2(0f, rg2D.position.y);
        rg2D.velocity = Vector2.zero;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Colliding with the ball and will only a ball/pong
        if (!collision.gameObject.CompareTag("Pong"))
        {
            return;
        }

        Rigidbody2D ball = collision.rigidbody;
        Collider2D paddle = collision.otherCollider;

        // Ixnformation about the collision of the ball
        Vector2 ballDirection = ball.velocity.normalized;
        Vector2 contactDistance = ball.transform.position - paddle.bounds.center;
        Vector2 surfaceNormal = collision.GetContact(0).normal;
        Vector3 rotationAxis = Vector3.Cross(Vector3.up, surfaceNormal);

        // Rotate the direction of the ball based on the contact distance
        // to make the gameplay more dynamic and interesting
        float maxBounceAngle = 75f;
        float bounceAngle = (contactDistance.y / paddle.bounds.size.y) * maxBounceAngle;
        ballDirection = Quaternion.AngleAxis(bounceAngle, rotationAxis) * ballDirection;

        // applying the new direction to the ball
        ball.velocity = ballDirection * ball.velocity.magnitude;
    }
}
