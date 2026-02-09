using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D RB;
    public float Speed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vel = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            vel.x = Speed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            vel.x = -Speed;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            vel.x = Speed;
            vel.x = Speed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            vel.y = -Speed;
        }

        RB.linearVelocity = new Vector2(vel.x, RB.linearVelocity.y);
    }
}
