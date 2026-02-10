using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D RB;
    public float speed = 5;
    void Start()
    {
        
    }

    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        Vector2 direction = new Vector2 (xInput, yInput);
        RB.linearVelocity = direction * speed;

    }
    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Enemy"))
        {
            Die();
        }
    }
        public void Die()
    {
        Destroy(gameObject);
    }
}
