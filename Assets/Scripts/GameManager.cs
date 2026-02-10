using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    public List<PlayerController> Player;

    void Start()
    {
        if (Instance)
            Destroy(gameObject);
        Instance = this;

    }


    void Update()
    {
        
    }
}
