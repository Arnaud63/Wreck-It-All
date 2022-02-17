using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SpawnPistol : MonoBehaviour
{
    [Inject]
    private PistolSpawner pistolSpawner;

    [SerializeField]
    private GameObject pistolPrefab;
    [SerializeField]
    private float spawnX;
    [SerializeField]
    private float spawnY;
    [SerializeField]
    private float spawnZ;

    void Awake()
    {
        pistolSpawner.SpawnWeapon(pistolPrefab, spawnX, spawnY, spawnZ);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
