using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header ("ScoreText")]
    public TMPro.TMP_Text singlePlayerScoreText;
    public TMPro.TMP_Text computerScoreText;

    [Header ("GameObjects")]
    public BallMovement ball;
    public Paddle singlePlayerPaddle;
    public Paddle aiPaddle;

    [Header("Score Number")]
    [SerializeField] private int singlePlayerScore;
    [SerializeField] private int AiScore;


    //// Versus 
    [Header("ScoreText Versus")]
    public TMPro.TMP_Text player1ScoreText;
    public TMPro.TMP_Text player2ScoreText;

    [Header("GameObjects Versus")]
    public Paddle player1Paddle;
    public Paddle player2Paddle;

    [Header("Score Number")]
    [SerializeField] private int player1Score;
    [SerializeField] private int player2Score;


    //Level Counter
    [Header("Level Counter")]
    [SerializeField] int levelCounter;


    public void Update()
    {
        ResetGame();
        BackKeyButton();

    }

    //Scoring System Single
    public void PlayerScores()
    {
        singlePlayerScore++;
        singlePlayerScoreText.text = singlePlayerScore.ToString();

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
        this.singlePlayerPaddle.ResetPositionPaddle();
        this.aiPaddle.ResetPositionPaddle();
        this.ball.ResettingBall();
    }

    //Versus
    public void Player1Scores()
    {
        player1Score++;
        player1ScoreText.text = player1Score.ToString();

        ResetRoundVersus();
    }

    public void Player2Scores()
    {
        player2Score++;
        player2ScoreText.text = player2Score.ToString();

        ResetRoundVersus();
    }

    public void ResetRoundVersus()
    {
        this.player1Paddle.ResetPositionPaddle();
        this.player2Paddle.ResetPositionPaddle();
        this.ball.ResettingBall();
    }

    //Score Reset
    public void ScoreReset()
    {
        singlePlayerScore = 0;
        AiScore = 0;

        singlePlayerScoreText.text = singlePlayerScore.ToString();
        computerScoreText.text = AiScore.ToString();

    }

    public void ScoreReset2()
    {
        player1Score = 0;
        player2Score = 0;

        player1ScoreText.text = player1Score.ToString();
        player2ScoreText.text = player2Score.ToString();
    }


    //Restaring Level
    public void ResetGame()
    {
        if (levelCounter == 1)
        {
            if (Input.GetKey(KeyCode.R))
            {
                ResetRound();
                ScoreReset();
            }
        }

        else if (levelCounter == 2)
        {
            if (Input.GetKey(KeyCode.R))
            {
                ResetRoundVersus();
                ScoreReset2();
            }
        }

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

    public void HorizontalLevel()
    {
        SceneManager.LoadScene("Horizontal");
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


    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
