using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
public class PistolSpawner : IWeaponSpawner
{
    public void SpawnWeapon(WeaponGlueCode weaponGlueCode, GameObject prefab, float spawnX, float spawnY, float spawnZ)
    {
        GameObject gun = GameObject.Instantiate(prefab, new Vector3(spawnX, spawnY, spawnZ), Quaternion.identity);
        AGun gunData = new Pistol();
        weaponGlueCode.LinkGameObjectToIWeaoon(gun, gunData);
    }
}
