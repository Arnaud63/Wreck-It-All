using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeaponSpawner
{
    void SpawnWeapon(GameObject prefab, float spawnX, float spawnY, float spawnZ);
}
