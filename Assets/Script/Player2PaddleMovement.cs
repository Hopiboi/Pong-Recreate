using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2PaddleMovement : Paddle
{

    private Vector2 playerDirection;

    private void Update()
    {
     
        //Control
        if (Input.GetKey(KeyCode.I))
        {
            playerDirection = Vector2.up;
        }

        else if (Input.GetKey(KeyCode.K))
        {
            playerDirection = Vector2.down;
        }

        else
        {
            playerDirection = Vector2.zero; // not pressing anything
        }


    }

    //FixedTime
    private void FixedUpdate()
    {
        if ( playerDirection.sqrMagnitude != 0)
        {
            rg2D.AddForce(playerDirection * this.paddleSpeed);
        }
    }


}

