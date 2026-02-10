using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D RB;
    public PlayerController Target;
    void Start()
    {
        
    }

   
    void Update()
    {
        Vector3 move = Vector3.MoveTowards(transform.position, Target.transform.position, 0.1f);
        RB.transform.position = move;
    }
}
