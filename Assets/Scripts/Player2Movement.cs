using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    public int boardSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        bool isPressingUp = Input.GetKey(KeyCode.UpArrow);
        bool isPressingDown = Input.GetKey(KeyCode.DownArrow);

        if(isPressingUp) 
        {
            transform.Translate(Vector2.up * Time.deltaTime * boardSpeed);
        }
        if(isPressingDown)
        {
            transform.Translate(Vector2.down * Time.deltaTime * boardSpeed);
        }
    }
}
