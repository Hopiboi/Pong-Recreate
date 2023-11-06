using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header ("ScoreText")]
    public TMPro.TMP_Text playerScoreText;
    public TMPro.TMP_Text player2ScoreText;
    public TMPro.TMP_Text computerScoreText;

    [Header ("GameObjects")]
    public BallMovement ball;
    public Paddle playerPaddle;
    public Paddle player2Paddle;
    public Paddle aiPaddle;

    [Header("Score Number")]
    [SerializeField] private int playerScore;
    [SerializeField] private int player2Score;
    [SerializeField] private int AiScore;


    public void Update()
    {
        ResetGame();
        BackKeyButton();
    }

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

    public void Player2Scores()
    {
        player2Score++;
        player2ScoreText.text = player2Score.ToString();

        ResetRound();
    }

    //Resetting
    public void ResetRound()
    {
        this.playerPaddle.ResetPositionPaddle();
        this.player2Paddle.ResetPositionPaddle();
        this.aiPaddle.ResetPositionPaddle();
        this.ball.ResettingBall();
    }

    //Menu Selector

    public void ClassicLevel()
    {
        SceneManager.LoadScene("Classic");
    }

    public void VersusLevel()
    {
        SceneManager.LoadScene("Versus");
    }

    //Button InGame
    public void BackKeyButton()
    {
        if (Input.GetKey(KeyCode.Escape)) { BackButton(); }
    }

    public void BackButton()
    {

        SceneManager.LoadScene("Main Menu");

    }

    //Restaring Level
    public void ResetGame()
    {
        if (Input.GetKey(KeyCode.R))
        {
            ResetRound();
            ScoreReset();
            
        }

        else if (Input.GetKey(KeyCode.Alpha2))
        {
            ScoreReset2();
        }
    }


    public void ScoreReset()
    {
        playerScore = 0;
        AiScore = 0;

        playerScoreText.text = playerScore.ToString();
        computerScoreText.text = AiScore.ToString();

    }

    public void ScoreReset2()
    {
        playerScore = 0;
        player2Score = 0;

        playerScoreText.text = playerScore.ToString();
        player2ScoreText.text = player2Score.ToString();

    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
