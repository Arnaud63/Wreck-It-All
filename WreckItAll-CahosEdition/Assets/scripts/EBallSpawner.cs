using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EBallSpawner : MonoBehaviour
{
    public GameObject eballprefab;
    private Vector3 spawnpoint;

    // Start is called before the first frame update
    void Start()
    {
        //Make an ball spawn every 0.3 seconds,
        //start after 2 seconds
        InvokeRepeating("SpawnEnemy", 2.0f, 10.0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    void SpawnEnemy()
    {
        this.spawnpoint = this.GetComponent<Transform>().position;
        this.spawnpoint.y -= 3;
        Instantiate(this.eballprefab, this.spawnpoint, Quaternion.identity);
    }
}
