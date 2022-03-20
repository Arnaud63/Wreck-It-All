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


    void Awake()
    {
        weaponGlueCode.SpawnWeapon(weaponSpawner, SwordPrefab, gameObject.transform);
    }
}
