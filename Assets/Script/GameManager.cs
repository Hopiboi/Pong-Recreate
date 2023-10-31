using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    //Scoring System
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

    //Resetting
    public void ResetRound()
    {
        this.playerPaddle.ResetPositionPaddle();
        this.aiPaddle.ResetPositionPaddle();
        this.ball.ResettingBall();
    }

    //Menu Selector

    public void ClassicLevel()
    {
        SceneManager.LoadScene("Classic");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
