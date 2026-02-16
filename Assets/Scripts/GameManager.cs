using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    public List<PlayerController> Player;

    void Awake()
    {
        if (Instance)
            Destroy(gameObject);
        Instance = this;

    }


    void Update()
    {
        
    }
}
