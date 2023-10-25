using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPaddle : Paddle
{
    //Accessing rigidbody in script in inspector
    public Rigidbody2D ball;
    
    private void FixedUpdate()
    {
        //if its going to right
        if (this.ball.velocity.x > 0f)
        {
            //if its going to up
            if(this.ball.position.y > this.transform.position.y)
            {
                rg2D.AddForce(Vector2.up * this.paddleSpeed);
            }
            else if (this.ball.position.y < this.transform.position.y)
            {
                rg2D.AddForce(Vector2.down * this.paddleSpeed);
            }
        }

        //variability to make player win
        else
        {
            if(this.transform.position.y > 0f)
            {
                rg2D.AddForce(Vector2.down * this.paddleSpeed);
            }
            else if (this.transform.position.y < 0f)
            {
                rg2D.AddForce(Vector2.up * this.paddleSpeed);
            }
        }
    }



}
