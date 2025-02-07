using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public int movementSpeed;
    void Start()
    {
        ResetBallPosition();
    }
    void Update()
    {
        
    }

    public void AddForce(Vector2 force) // Adding ball movement speed everytime
    {
        rb2d.AddForce(force);
    }

    public void ResetBallPosition() 
    {
        rb2d.position = Vector2.zero;
        bool isLeft = UnityEngine.Random.value > 0.5f;
        float xVelocity = 1f;
        if(isLeft)
        {
            xVelocity = -1f;
        }

        float yVelocity = UnityEngine.Random.Range(-1f, 1f);
        rb2d.linearVelocity = new Vector2(xVelocity * movementSpeed , yVelocity);
    }
}
