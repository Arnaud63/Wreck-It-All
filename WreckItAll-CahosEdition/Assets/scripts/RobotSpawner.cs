using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class RobotSpawner : MonoBehaviour
{
    [Inject]
    private InjectedPrefabFactory injectedPrefabFactory;
    [Inject]
    private EnemysManager enemysManager;

    [SerializeField]
    private GameObject robotPrefab;
    [SerializeField]
    private float startSpawnAfter = 1;
    [SerializeField]
    private float secondsBetweenSpawn = 10;

    // Start is called before the first frame update
    void Start()
    {
        if(this.robotPrefab == null)
            throw new UnassignedReferenceException("No Robot prefab assigned");
        InvokeRepeating("SpawnEnemy", startSpawnAfter, secondsBetweenSpawn);
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
        var enemy = injectedPrefabFactory.InstantiateInjectedPrefab(this.robotPrefab,
            this.GetComponent<Transform>().position, Quaternion.identity);
        enemysManager.LinkGameObjectToIEnemy(enemy, new Soldat());
    }
}
