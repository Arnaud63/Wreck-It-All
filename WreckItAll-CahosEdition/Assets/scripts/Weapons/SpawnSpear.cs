using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SpawnSpear : MonoBehaviour
{
    [Inject]
    private WeaponManager weaponGlueCode;
    [Inject]
    public IWeaponSpawner weaponSpawner;

    [SerializeField]
    private GameObject SpearPrefab;

    void Awake()
    {
        weaponGlueCode.SpawnWeapon(weaponSpawner, SpearPrefab, gameObject.transform);
    }
}
