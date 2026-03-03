using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D RB;
    public float speed = 5;

    public GameObject BulletPrefab;
    public float bulletSpeed = 10f;
    public Transform SpawnPoint;

    Animator anim;
    public bool moving;

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        GameManager.Instance.Player.Add(this);

    }

    private void OnDestroy()
    {
        GameManager.Instance.Player.Remove(this);
    }


    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        Vector2 direction = new Vector2 (xInput, yInput);
        RB.linearVelocity = direction * speed;

       if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
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

    public void Shoot()
    {
        GameObject Bullet = Instantiate(BulletPrefab);
    }
        
}
