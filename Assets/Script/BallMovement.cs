using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    [SerializeField] private float ballSpeed = 200f;

    private Rigidbody2D rg2D;




    private void Start()
    {
        rg2D = GetComponent<Rigidbody2D>();

        StartingSpeed();
        StartingBall();

    }

    //In case when the ball is not on center
    public void StartingBall()
    {     
        rg2D.position = Vector2.zero;
        rg2D.velocity = Vector2.zero;

    }

    //Creating Force
    private void StartingSpeed()
    {
        //Random in left or right
        float x = Random.value < 0.5f ? -1f : 1f    ;

        // Down and Up
        float y = Random.value < 0.5f ? Random.Range(-1f, -.5f):
                                        Random.Range(0.5f, 1f); // Angle
        
        
        //adding direction
        Vector2 direction = new Vector2(x, y);
        rg2D.AddForce(direction * ballSpeed);

    }

    public void AddingForce(Vector2 force)
    {
        rg2D.AddForce(force);
    }

    //Reset
    public void ResettingBall()
    {
        //Vector3 can be used, but prefered Vector2 because of 2D elements
        rg2D.position = Vector2.zero;
        rg2D.velocity = Vector2.zero;


        //To start the Force again
        StartingSpeed();
    }

}
