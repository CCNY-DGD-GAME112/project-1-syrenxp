using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D RB;
    public PlayerController Target;

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        Vector3 move = Vector3.MoveTowards(transform.position, Target.transform.position, 0.1f);
        RB.MovePosition(move); 
    }
}
