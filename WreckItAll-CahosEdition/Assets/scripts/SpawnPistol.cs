using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SpawnPistol : MonoBehaviour
{
    [Inject]
    private WeaponManager weaponGlueCode;
    //Faire interface qui référence uniquement la méthode que je vais
    //utiliser, respect principes SOLID, forte encapsulation
    //moq -> faire des tests unitaires
    //Injection d'interface
    [Inject]
    public IWeaponSpawner weaponSpawner;

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
