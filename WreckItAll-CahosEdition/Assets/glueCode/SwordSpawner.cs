using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SwordSpawner : IWeaponSpawner
{
    [Inject]
    private InjectedPrefabFactory injectedPrefabFactory;
    public void SpawnWeapon(WeaponManager weaponGlueCode, GameObject prefab, Transform transform)
    {
        GameObject sword = injectedPrefabFactory.InstantiateInjectedPrefab(prefab,
            transform.position, transform.rotation);

        IWeapon swordData = new Sword(1);
        weaponGlueCode.LinkGameObjectToIWeaoon(sword, swordData);
    }
}
