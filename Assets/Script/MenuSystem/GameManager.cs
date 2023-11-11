using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header ("ScoreText")]
    public TMPro.TMP_Text singlePlayerScoreText;
    public TMPro.TMP_Text computerScoreText;

    [Header ("Ball GameObject")]
    public BallMovement ball;

    [Header("SinglePlayer")]
    public Paddle singlePlayerPaddle;
    public Paddle aiPaddle;

    [Header("Score Number")]
    [SerializeField] private int singlePlayerScore;
    [SerializeField] private int AiScore;


    //// Versus 
    [Header("ScoreText Versus")]
    public TMPro.TMP_Text player1ScoreText;
    public TMPro.TMP_Text player2ScoreText;
    public TMPro.TMP_Text player3ScoreText;
    public TMPro.TMP_Text player4ScoreText;

    [Header("GameObjects Versus")]
    public Paddle player1Paddle;
    public Paddle player2Paddle;
    public Paddle player3Paddle;
    public Paddle player4Paddle;

    [Header("Score Number")]
    [SerializeField] private int player1Score;
    [SerializeField] private int player2Score;
    [SerializeField] private int player3Score;
    [SerializeField] private int player4Score;

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


        if (levelCounter == 1)
        {
            this.singlePlayerPaddle.ResetPositionPaddle();
            this.aiPaddle.ResetPositionPaddle();
            this.ball.ResettingBall();
        }

        else if (levelCounter == 3)
        {
            this.singlePlayerPaddle.ResetPositionPaddleHorizontal();
            this.aiPaddle.ResetPositionPaddleHorizontal();
            this.ball.ResettingBall();
        }
    }

    //Versus
    //Scoring system to other players
    public void Player1Scores()
    {

        if (levelCounter == 2 || levelCounter == 4)
        {
            player1Score++;
            player1ScoreText.text = player1Score.ToString();

            ResetRoundVersus();
        }

        else if (levelCounter == 5)
        {
            if(this.ball.winPlayerNum == 1)
            {
                player1Score++;
                player1ScoreText.text = player1Score.ToString();

                ResetRoundVersus();
                this.ball.ResetColor();
            }

        }

    }

    public void Player2Scores()
    {

        if (levelCounter == 2 || levelCounter == 4)
        {
            player2Score++;
            player2ScoreText.text = player2Score.ToString();

            ResetRoundVersus();
        }

        else if (levelCounter == 5)
        {
            if (this.ball.winPlayerNum == 2)
            {
                player2Score++;
                player2ScoreText.text = player2Score.ToString();

                ResetRoundVersus();
                this.ball.ResetColor();
            }

        }
    }

    public void Player3Scores()
    {
        if (levelCounter == 5)
        {
            if (this.ball.winPlayerNum == 3)
            {
                player3Score++;
                player3ScoreText.text = player3Score.ToString();

                ResetRoundVersus();
                this.ball.ResetColor();
            }

        }
    }

    public void Player4Scores()
    {
        if (levelCounter == 5)
        {
            if (this.ball.winPlayerNum == 4)
            {
                player4Score++;
                player4ScoreText.text = player4Score.ToString();

                ResetRoundVersus();
                this.ball.ResetColor();
            }
        }
    }

    //when the pong did not change the color

    public void FreeScore()
    {
        if (levelCounter == 5)
        {
            if (this.ball.winPlayerNum == 0)
            {
                player1Score++;
                player1ScoreText.text = player1Score.ToString();

                player2Score++;
                player2ScoreText.text = player2Score.ToString();

                player3Score++;
                player3ScoreText.text = player3Score.ToString();

                player4Score++;
                player4ScoreText.text = player4Score.ToString();

                ResetRoundVersus();
                this.ball.ResetColor();
            }
        }
    }

    //Resetting Round for versus

    public void ResetRoundVersus()
    {
        if (levelCounter == 2)
        {
            this.player1Paddle.ResetPositionPaddle();
            this.player2Paddle.ResetPositionPaddle();
            this.ball.ResettingBall();
        }

        else if (levelCounter == 4)
        {
            this.player1Paddle.ResetPositionPaddleHorizontal();
            this.player2Paddle.ResetPositionPaddleHorizontal();
            this.ball.ResettingBall();
        }

        else if (levelCounter == 5)
        {
            this.player1Paddle.ResetPositionPaddle();
            this.player2Paddle.ResetPositionPaddle();
            this.player3Paddle.ResetPositionPaddleHorizontal();
            this.player4Paddle.ResetPositionPaddleHorizontal();
            this.ball.ResettingBall();
            
            
        }

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
        if (levelCounter == 2 || levelCounter == 4)
        {
            player1Score = 0;
            player2Score = 0;

            player1ScoreText.text = player1Score.ToString();
            player2ScoreText.text = player2Score.ToString();
        }

        else if (levelCounter == 5)
        {
            player1Score = 0;
            player2Score = 0;
            player3Score = 0;
            player4Score = 0;

            player1ScoreText.text = player1Score.ToString();
            player2ScoreText.text = player2Score.ToString();
            player3ScoreText.text = player2Score.ToString();
            player4ScoreText.text = player2Score.ToString();
        }
        
        // player1Score = 0;
        // player2Score = 0;

        // player1ScoreText.text = player1Score.ToString();
        // player2ScoreText.text = player2Score.ToString();
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

        else if (levelCounter == 3)
        {
            if (Input.GetKey(KeyCode.R))
            {
                ResetRound();
                ScoreReset();
            }
        }

        else if (levelCounter == 4)
        {
            if (Input.GetKey(KeyCode.R))
            {
                ResetRoundVersus();
                ScoreReset2();
            }
        }

        else if (levelCounter == 5)
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

    public void HorizontalVersusLevel()
    {
        SceneManager.LoadScene("Horizontal Versus");
    }

    public void FourVersusLevel()
    {
        SceneManager.LoadScene("Four Versus");
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
