using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SwordSpawner : IWeaponSpawner
{
    [Inject]
    private InjectedPrefabFactory injectedPrefabFactory;
    public void SpawnWeapon(WeaponManager weaponGlueCode, GameObject prefab, float spawnX, float spawnY, float spawnZ)
    {
        GameObject sword = injectedPrefabFactory.InstantiateInjectedPrefab(prefab,
            new Vector3(spawnX, spawnY, spawnZ));

        IWeapon swordData = new Sword(1);
        weaponGlueCode.LinkGameObjectToIWeaoon(sword, swordData);
    }
}
