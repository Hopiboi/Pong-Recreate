using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header ("ScoreText")]
    public TMPro.TMP_Text playerScoreText;
    public TMPro.TMP_Text computerScoreText;

    [Header ("GameObjects")]
    public BallMovement ball;
    public Paddle playerPaddle;
    public Paddle aiPaddle;

    [Header("Score Number")]
    [SerializeField] private int playerScore;
    [SerializeField] private int AiScore;

    public void PlayerScores()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();

        ResetRound();
    }


     public void AIScores()
    {
        AiScore++;
        computerScoreText.text = AiScore.ToString();

        ResetRound();

    }

    public void ResetRound()
    {
        this.playerPaddle.ResetPositionPaddle();
        this.aiPaddle.ResetPositionPaddle();
        this.ball.ResettingBall();

    }
    
}
