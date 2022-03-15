using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SpawnAK : MonoBehaviour
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
    private GameObject AKPrefab;

    void Awake()
    {
        weaponGlueCode.SpawnWeapon(weaponSpawner, AKPrefab, gameObject.transform);
    }
}
