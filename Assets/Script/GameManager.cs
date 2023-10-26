using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public BallMovement ball;

    private int playerScore;

    private int AiScore;

    public void PlayerScores()
    {
        playerScore++;

        this.ball.ResettingBall();
    }


     public void AIScores()
    {
        AiScore++;

        this.ball.ResettingBall();
    }

    
}
