using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SpawnPistol : MonoBehaviour
{
    [Inject]
    private WeaponManager weaponGlueCode;
    [Inject]
    public IWeaponSpawner weaponSpawner;

    [SerializeField]
    private GameObject PistolPrefab;

    void Awake()
    {
        weaponGlueCode.SpawnWeapon(weaponSpawner, PistolPrefab, gameObject.transform);
    }
}
