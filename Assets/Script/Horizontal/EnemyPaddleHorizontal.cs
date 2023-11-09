using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPaddleHorizontal : Paddle
{
    //Accessing rigidbody in script in inspector
    public Rigidbody2D ball;
    
    private void FixedUpdate()
    {
        //if its going to right
        if (this.ball.velocity.y > 0f)
        {
            //if its going to up
            if(this.ball.position.x > this.transform.position.x)
            {
                rg2D.AddForce(Vector2.right * this.paddleSpeed);
            }
            else if (this.ball.position.x < this.transform.position.x)
            {
                rg2D.AddForce(Vector2.left * this.paddleSpeed);
            }
        }

        //variability to make player win
        else
        {
            if(this.transform.position.x > 0f)
            {
                rg2D.AddForce(Vector2.left * this.paddleSpeed);
            }
            else if (this.transform.position.x < 0f)
            {
                rg2D.AddForce(Vector2.right * this.paddleSpeed);
            }
        }
    }



}
