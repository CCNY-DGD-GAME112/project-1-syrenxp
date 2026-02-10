using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    
    void Start()
    {

    }

    public TextMeshProUGUI timerText;
    public float timer = 5;
    public GameObject EnemyPrefab;

  
    void Update()
    {
        timer -= Time.deltaTime;
        timerText.text = timer.ToString("F2");
        if (timer <= 0)
        {
            Vector3 where = new Vector3(Random.Range(-8f, 8f),
            Random.Range(-4f, 4f), 0);
            Instantiate(EnemyPrefab, where, Quaternion.identity);
            timer = 5;
        }
    }
}

