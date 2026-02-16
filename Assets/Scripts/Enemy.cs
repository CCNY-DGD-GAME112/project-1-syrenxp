using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D RB;
    public PlayerController Target;
    public float Speed = 1.0f;

    private Transform target;

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();

        if (GameManager.Instance.Player.Count > 0)
        {
            target = GameManager.Instance.Player[0].transform;
        }
    }


    void Update()
    {
        if (target == null) return;

        transform.position = Vector2.MoveTowards(
            transform.position,
            target.position,
            Speed * Time.deltaTime
            );
    }

}
