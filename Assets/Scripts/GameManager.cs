using TMPro;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    private int player1Score;
    private int player2Score;
    public BallMovement ball;
    public TMP_Text player1ScoreText;
    public TMP_Text player2ScoreText;

    public void Player1Score()
    {
        player1Score++;
        ball.ResetBallPosition();
        player1ScoreText.text = player1Score.ToString();
    }

    public void Player2Score()
    {
        player2Score++;
        ball.ResetBallPosition();
        player2ScoreText.text = player2Score.ToString();
    }

    public void ResetScore() 
    {
        player1Score = 0;
        player2Score = 0;
        ball.ResetBallPosition();
    }

}
