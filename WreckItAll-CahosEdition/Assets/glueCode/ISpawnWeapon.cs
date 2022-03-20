using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISpawnWeapon
{
    public void SpawnWeapon(IWeaponSpawner spawner, GameObject prefab, Transform transform);
}
