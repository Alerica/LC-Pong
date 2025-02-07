using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int boardSpeed;
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
            transform.Translate(Vector2.up * Time.deltaTime * boardSpeed);
        }
        if(isPressingDown)
        {
            transform.Translate(Vector2.down * Time.deltaTime * boardSpeed);
        }
    }
}
