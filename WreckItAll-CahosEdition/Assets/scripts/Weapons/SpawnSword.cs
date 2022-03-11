using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SpawnSword : MonoBehaviour
{
    [Inject]
    private WeaponManager weaponGlueCode;
    [Inject]
    public IWeaponSpawner weaponSpawner;

    [SerializeField]
    private GameObject SwordPrefab;
    [SerializeField]
    private float spawnX;
    [SerializeField]
    private float spawnY;
    [SerializeField]
    private float spawnZ;


    void Awake()
    {
        weaponGlueCode.SpawnWeapon(weaponSpawner, SwordPrefab, spawnX, spawnY, spawnZ);
    }
}
