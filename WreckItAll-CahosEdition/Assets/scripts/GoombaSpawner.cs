using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaSpawner : MonoBehaviour
{
    public GameObject goombaprefab;
    private Vector3 spawnpoint;

    // Start is called before the first frame update
    void Start()
    {
        //Make a goomba spawn every 10 seconds,
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
        Instantiate(this.goombaprefab, this.spawnpoint, Quaternion.identity);
    }
}
