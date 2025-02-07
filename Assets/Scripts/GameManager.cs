using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int player1Score;
    private int player2Score;
    public BallMovement ball;

    public void Player1Score()
    {
        player1Score++;
        ball.ResetBallPosition();
    }

    public void Player2Score()
    {
        player2Score++;
        ball.ResetBallPosition();
    }

}
