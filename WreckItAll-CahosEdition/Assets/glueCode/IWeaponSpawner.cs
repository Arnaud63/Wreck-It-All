using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeaponSpawner
{
    public void SpawnWeapon(WeaponManager weaponGlueCode, GameObject prefab, Transform transform);
}
