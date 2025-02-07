using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int paddleSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isPressingUp = Input.GetKey(KeyCode.W);
        bool isPressingDown = Input.GetKey(KeyCode.S);

        if(isPressingUp) 
        {
            transform.Translate(Vector2.up * Time.deltaTime * (1 + paddleSpeed));
        }
        if(isPressingDown)
        {
            transform.Translate(Vector2.down * Time.deltaTime * (1 + paddleSpeed));
        }
    }
}
