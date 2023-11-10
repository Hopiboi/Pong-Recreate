using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player4PaddleHorizontalMovement : Paddle
{

    private Vector2 playerDirection;

    private void Update()
    {
     
        //Control
        if (Input.GetKey(KeyCode.Keypad4))
        {
            playerDirection = Vector2.left;
        }

        else if (Input.GetKey(KeyCode.Keypad6))
        {
            playerDirection = Vector2.right;
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

