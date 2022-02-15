using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PistolSpawner : IWeaponSpawner
{
    [Inject]
    private Pistol pistol;
    private GameObject pistolPrefab;

    void IWeaponSpawner.SpawnWeapon()
    {
        pistolPrefab = (GameObject) Resources.Load("prefabs/Gun");
        GameObject.Instantiate(pistolPrefab, new Vector3(0, 3, 0), Quaternion.identity);
        //Logique de spawn d'un pistol
    }
}
