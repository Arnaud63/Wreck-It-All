using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SpawnPistol : MonoBehaviour
{
    [Inject]
    private PistolSpawner pistolSpawner;

    void Awake()
    {
        pistolSpawner.SpawnWeapon();
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
