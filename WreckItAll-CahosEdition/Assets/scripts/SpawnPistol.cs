using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SpawnPistol : MonoBehaviour
{
    [Inject]
    private WeaponGlueCode weaponGlueCode;
    [Inject]
    public PistolSpawner weaponSpawner;

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
        weaponGlueCode.SpawnWeapon(weaponSpawner, pistolPrefab, spawnX, spawnY, spawnZ);
    }
}
