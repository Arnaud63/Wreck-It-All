using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeaponSpawner
{
    public void SpawnWeapon(WeaponGlueCode weaponGlueCode, GameObject prefab, float spawnX, float spawnY, float spawnZ);
}
