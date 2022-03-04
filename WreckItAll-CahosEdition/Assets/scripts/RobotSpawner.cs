using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject robotPrefab;

    // Start is called before the first frame update
    void Start()
    {
        if(this.robotPrefab == null)
        {
            throw new UnassignedReferenceException("No Robot prefab assigned");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("f"))
        {
            this.SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        Instantiate(this.robotPrefab, this.GetComponent<Transform>().position, Quaternion.identity);
    }
}
