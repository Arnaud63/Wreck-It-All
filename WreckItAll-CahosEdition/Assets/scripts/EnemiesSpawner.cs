using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawner : MonoBehaviour
{
    public GameObject enemy_prefab;

    // Start is called before the first frame update
    void Start()
    {
        //Make an enemy spawn every 0.3 seconds,
        //start after 2 seconds
        InvokeRepeating("SpawnEnemy", 2.0f, 0.1f);
    }

    void FixedUpdate()
    {
        
    }

    void SpawnEnemy() {
        Instantiate(this.enemy_prefab, this.GetComponent<Transform>().position, Quaternion.identity);
    }
}
